using AddisonWesley.Michaelis.EssentialCSharp.Shared;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.CodeDom.Compiler;
using System.Globalization;
using System.Text;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter03.Table03_03.Tests
{
    [TestClass]
    public class ArrayHighlightsTests
    {
        public Dictionary<string, string?> CompilerErrorMessages { get; } = new Dictionary<string, string?>()
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
        public TestContext TestContext { get; set; } = null!; // Set by MSTest;

        private const string FileName = "Table03.03.CommonArrayCodingErrors.cs";


        [TestMethod]
        /* 1. */ [DataRow(nameof(CommonArayCodingErrors.SquareBracketsOnVariableRatherThanType), "CS0650")]
        /* 2. */ [DataRow(nameof(CommonArayCodingErrors.NewKeywordWithDataTypeRequired), "CS1525", "CS1002", "CS1002", "CS1513", "CS1002", "CS1513", "CS1002")]
        /* 3. */ [DataRow(nameof(CommonArayCodingErrors.ArraySizeCannotBeSpecifiedInDataType), "CS0270")]
        /* 4. */ [DataRow(nameof(CommonArayCodingErrors.ArraySizeOrInitializerIsRequired), "CS1586")]
        /* 5. */ [DataRow(nameof(CommonArayCodingErrors.ArraySizeWithEmptyInitializer), "CS0847")]
        /* 9. */ [DataRow(nameof(CommonArayCodingErrors.MultiDimensionalArrayWithInconsistentSize), "CS0847")]
        public async Task ParseAndCompiler(string targetMethod, params string[] errorIds)
        {
            string code = new StreamReader(FileName).ReadToEnd();
            SyntaxTree syntaxTree = CSharpSyntaxTree.ParseText(code, new CSharpParseOptions().WithPreprocessorSymbols("INCLUDE"));
            CompilationUnitSyntax root = (CompilationUnitSyntax)syntaxTree.GetRoot();
            NamespaceDeclarationSyntax namespaceRoot = 
                root.Members.OfType<NamespaceDeclarationSyntax>().First();
            ClassDeclarationSyntax classRoot = 
                namespaceRoot.Members.OfType<ClassDeclarationSyntax>().First();
            MethodDeclarationSyntax methodBody = 
                classRoot.Members.OfType<MethodDeclarationSyntax>().First(
                    item=>item.Identifier.Text == targetMethod)!;

            // TODO: Switch to use Roslyn for compilation
            code = methodBody.Body!.Statements.ToString()!;
            CompileError[] compilerErrors = await CompilerAssert.CompileAsync(code);
            TestContext.WriteLine("CompileIds:" + string.Join(", ", compilerErrors.Select(item => item.Id).ToArray()));
            CollectionAssert.AreEquivalent(errorIds, compilerErrors.Select(item => item.Id).ToList());
            if (CultureInfo.CurrentCulture.Name != "en-US")
            {
                TestContext.WriteLine("Due to Culture, compiler error messages are not the same:");
            }
            foreach (CompileError item in compilerErrors)
            {
                if (CultureInfo.CurrentCulture.Name == "en-US")
                {
                    TestContext.WriteLine($"{{\"{item.Id}\", \"{item.Message}\"}}");
                    if (CompilerErrorMessages[item.Id] != null) Assert.AreEqual(item.Message, CompilerErrorMessages[item.Id]);
                }
                else
                {
                    TestContext.WriteLine($"\t\"{item.Message}\" != \"{CompilerErrorMessages[item.Id]}\"");
                }
            }
            //Assert.IsTrue(compilerErrors.Select(item=>item.Id).SequenceEqual(errorIds));
        }


        // 6.
        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void IndexingOffTheEndOfArrayTest()
        {
            CommonArayCodingErrors.IndexingOffTheEndOfArray();
        }

        // 7.
        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void Hat0IsOnePastTheEndOfTheArray1Test()
        {
            CommonArayCodingErrors.Hat0IsOnePastTheEndOfTheArray1();
        }

        // 8.
        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void Hat0IsOnePastTheEndOfTheArray2Test()
        {
            CommonArayCodingErrors.LastItemIsLengthMinus1();
        }
    }
}