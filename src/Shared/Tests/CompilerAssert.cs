using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.Diagnostics;
using Microsoft.CodeAnalysis.Testing;
using Microsoft.CodeAnalysis.Testing.Verifiers;
using System.Collections.Immutable;

namespace AddisonWesley.Michaelis.EssentialCSharp.Shared.Tests;

public static class CompilerAssert
{
    public static async Task CompileAsync(string[] fileNames, string[] expectedErrorIds)
    {
        string code = string.Empty;
        foreach (string fileName in fileNames)
        {
            code += Environment.NewLine + await File.ReadAllTextAsync(fileName);
        }
        
        var test = new Test()
        {
            TestCode = code
        };
        foreach(var errorId in expectedErrorIds)
        {
            test.ExpectedDiagnostics.Add(DiagnosticResult.CompilerError(errorId));
        }

        await test.RunAsync();
    }
    public static async Task CompileAsync(string fileName, params string[] expectedErrorIds) =>
        await CompileAsync(new string[] { fileName }, expectedErrorIds);


    //Custom verifier to ignore diagnostic locations locations
    public class CustomMSTestVerifier : MSTestVerifier
    {
        public override void Equal<T>(T expected, T actual, string? message = null)
        {
            if (typeof(T) == typeof(Location))
            {
                return;
            }
            base.Equal(expected, actual, message);
        }
    }

    private class Test : AnalyzerTest<CustomMSTestVerifier>
    {
        protected override CompilationOptions CreateCompilationOptions()
        {
            var compilationOptions = new CSharpCompilationOptions(
                OutputKind.DynamicallyLinkedLibrary, 
                allowUnsafe: true,
                //Setup set #nullable enable
                nullableContextOptions: NullableContextOptions.Enable);

            return compilationOptions
                .WithSpecificDiagnosticOptions(
                 compilationOptions.SpecificDiagnosticOptions.SetItems(GetNullableWarningsFromCompiler()));
        }

        public LanguageVersion LanguageVersion { get; set; } = LanguageVersion.Default;
        protected override string DefaultFileExt => "cs";
        public override string Language => LanguageNames.CSharp;

        private static ImmutableDictionary<string, ReportDiagnostic> GetNullableWarningsFromCompiler()
        {
            string[] args = Array.Empty<string>();
            //TODO: if we care to elevate NRT warnings, you can do it like this:
            //string[] args = { "/warnaserror:nullable" };
            var commandLineArguments = CSharpCommandLineParser.Default.Parse(args, baseDirectory: Environment.CurrentDirectory, sdkDirectory: Environment.CurrentDirectory);
            var nullableWarnings = commandLineArguments.CompilationOptions.SpecificDiagnosticOptions;

            return nullableWarnings;
        }

        protected override ParseOptions CreateParseOptions()
            => new CSharpParseOptions(LanguageVersion, DocumentationMode.Diagnose)
                   .WithPreprocessorSymbols("COMPILEERROR")
#if NET7_0_OR_GREATER
                    .WithPreprocessorSymbols("NET7_0_OR_GREATER")
#endif // NET7_0_OR_GREATER
            ;

        protected override IEnumerable<DiagnosticAnalyzer> GetDiagnosticAnalyzers()
            => Enumerable.Empty<DiagnosticAnalyzer>();
    }
}
