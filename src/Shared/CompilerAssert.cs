using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Scripting;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Scripting;
using System.Globalization;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddisonWesley.Michaelis.EssentialCSharp.Shared;

readonly public struct CompileError
{
    public static Dictionary<string, string?> CompilerErrorMessages { get; } = new Dictionary<string, string?>()
    {
        {"CS0650", "Bad array declarator: To declare a managed array the rank specifier precedes the variable's identifier. To declare a fixed size buffer field, use the fixed keyword before the field type." },
        {"CS1525", "Invalid expression term '{'"},
        {"CS1002", "; expected"},
        {"CS1513", "} expected"},
        {"CS0270", "Array size cannot be specified in a variable declaration (try initializing with a 'new' expression)"},
        {"CS1586", "Array creation must have array size or array initializer"},
        {"CS0847", null}, // "An array initializer of length 'X' is expected"
        //{"CS0847", "An array initializer of length '1' is expected"}
    };

    public string Id { get; }
    public string Message { get; }

    public CompileError(string fullMessage)
    {
        string[] parts = fullMessage.Split(": ");
        if (parts.Length != 2)
        {
            throw new ArgumentException(
                "Message is not of the form Id: Message", nameof(fullMessage));
        }
        Id = parts[0];
        Message = parts[1];
    }
    public CompileError(string id, string message)
    {
        Id = id;
        Message = message;
    }
    public void Deconstruct(out string id, out string message)
    {
        (id, message) = (Id, Message);
    }
    public override string ToString()
    {
        return $"{Id}: {Message}";
    }

    // override object.Equals
    public override bool Equals(object? obj)
    {
        return (obj is CompileError error)
          && Equals(error);
    }

    // Implemented IEquitable<T>
    public bool Equals(CompileError rhs)
    {
        return (Id, Message).Equals(
          (rhs.Id, rhs.Message));
    }


    // override object.GetHashCode
    public override int GetHashCode() =>
        (Id, Message).GetHashCode();


    public static bool operator ==(
        CompileError lhs, CompileError rhs) =>
            lhs.Equals(rhs);

    public static bool operator !=(
        CompileError lhs, CompileError rhs) =>
            !lhs.Equals(rhs);
}

static public class CompilerAssertOld
{
    public static async Task Compile2Async(
        string fileName,
        string[] errorIds,
        string? targetMethod) => await CompileAsync(
            new string[] { fileName }, errorIds, targetMethod);

    public static async Task CompileAsync(string[] fileNames, string[] errorIds, string? targetMethod = null)
    {
        string code = string.Empty;
        List<SyntaxTree> syntaxTrees = new();
        foreach (string fileName in fileNames)
        {
            code += Environment.NewLine + await File.ReadAllTextAsync(fileName);
        }

        if (string.IsNullOrEmpty(code))
        {
            throw new InvalidOperationException("There is no code to parse.");
        }

        CompileError[] compilerErrors;

        SyntaxTree syntaxTree = CSharpSyntaxTree.ParseText(code,
            new CSharpParseOptions().WithPreprocessorSymbols("INCLUDE"));

        if (targetMethod is not null)
        {
            CompilationUnitSyntax root = (CompilationUnitSyntax)syntaxTree.GetCompilationUnitRoot();
            NamespaceDeclarationSyntax namespaceRoot =
                root.Members.OfType<NamespaceDeclarationSyntax>().First();
            ClassDeclarationSyntax classRoot =
                namespaceRoot.Members.OfType<ClassDeclarationSyntax>().First();

            MethodDeclarationSyntax methodBody =
                classRoot.Members.OfType<MethodDeclarationSyntax>().First(
                    item => item.Identifier.Text == targetMethod)!;

            // TODO: Switch to use Roslyn for compilation
            code = methodBody.Body!.Statements.ToString()!;

            syntaxTree = CSharpSyntaxTree.ParseText(code,
                new CSharpParseOptions().WithPreprocessorSymbols("INCLUDE"));
            compilerErrors = await CompileAsyncOld(code);
        }
        else
        {
            compilerErrors = syntaxTree.GetDiagnostics().Select(item =>
                    new CompileError(item.Id, item.GetMessage())).ToArray();
        }


        Debug.WriteLine("CompileIds:" + string.Join(", ", compilerErrors.Select(item => item.Id).ToArray()));
        CollectionAssert.AreEquivalent(errorIds, compilerErrors.Select(item => item.Id).ToList());
        if (CultureInfo.CurrentCulture.Name != "en-US")
        {
            Debug.WriteLine("Due to Culture, compiler error messages are not the same:");
        }
        foreach (CompileError item in compilerErrors)
        {
            if (CultureInfo.CurrentCulture.Name == "en-US")
            {
                Debug.WriteLine($"{{\"{item.Id}\", \"{item.Message}\"}}");
                if (CompileError.CompilerErrorMessages[item.Id] != null) Assert.AreEqual(item.Message, CompileError.CompilerErrorMessages[item.Id]);
            }
            else
            {
                Debug.WriteLine($"\t\"{item.Message}\" != \"{CompileError.CompilerErrorMessages[item.Id]}\"");
            }
        }

    }

    public static async Task<CompileError[]> CompileAsyncOld(
        string sourceCode)
    {
        CompileError[] actualCompileErrors = Array.Empty<CompileError>();
        try
        {
            await CSharpScript.EvaluateAsync(sourceCode);
        }
        catch (CompilationErrorException exception)
        {
            Assert.IsTrue(exception.Diagnostics.Length > 0);

            actualCompileErrors = exception.Diagnostics.Select(item =>
                new CompileError(item.Id, item.GetMessage())).ToArray();

        }
        return actualCompileErrors;
    }
}
