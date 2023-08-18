using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.Diagnostics;
using Microsoft.CodeAnalysis.Testing;
using Microsoft.CodeAnalysis.Testing.Verifiers;
using System.Collections.Immutable;
using System.Diagnostics;

namespace AddisonWesley.Michaelis.EssentialCSharp.Shared.Tests;

public static class CompilerAssert
{
    public static async Task CompileAsync(string[] fileNames, string[] expectedErrorIds)
    {

        var test = new Test()
        {
            CompilerDiagnostics = CompilerDiagnostics.Warnings,
            ReferenceAssemblies = new ReferenceAssemblies(
                        "net7.0",
                        new PackageIdentity(
                            "Microsoft.NETCore.App.Ref",
                            "7.0.0"),
                        Path.Combine("ref", "net7.0"))
        };

        foreach (string eachFileName in fileNames)
        {
            IEnumerable<string>? fileNamesToCompile;
            if (!File.Exists(eachFileName))
            {
                // Search up to find the file in the target project directory.
                string testCsprojName = Path.GetFileName(
                    Path.ChangeExtension(System.Reflection.Assembly.GetExecutingAssembly().Location, "csproj"));
                // TODO: Update to search up each directory if the hard coded location 3 directories up is not correct.
                string currentChapterTestDirectory = Path.GetFullPath(
                    Path.Combine("..", "..", "..", testCsprojName));
                string? currentTargetDirectory = Path.GetDirectoryName(currentChapterTestDirectory.Replace(".Tests", ""));
                if ((Path.Join(currentTargetDirectory, eachFileName) is string temp) && File.Exists(temp))
                {
                    fileNamesToCompile = Enumerable.Repeat(eachFileName, 1);
                }
                else if (currentTargetDirectory is not null)
                {
                    // Perhaps we have a wildcard in the file name.
                    fileNamesToCompile = Directory.EnumerateFiles(
                        currentTargetDirectory,
                        eachFileName,
                        SearchOption.TopDirectoryOnly);
                }
                else
                {
                    throw new ArgumentException(
                        $"Specified file, { eachFileName } does not exist.");
                }
            }
            else
            {
                fileNamesToCompile = Enumerable.Repeat(eachFileName, 1);
            }
            foreach (string fileName in fileNamesToCompile)
            {
                test.TestState.Sources.Add((Path.GetFileName(fileName), await File.ReadAllTextAsync(fileName)));
            }
        }

        // Note: GeneratedSources is ignored.
        test.TestState.Sources.Add(("GlobalUsings.cs", await File.ReadAllTextAsync("GlobalUsings.cs")));

        test.DisabledDiagnostics.Add("CS1587"); // XML comment is not placed on a valid language element
        test.DisabledDiagnostics.Add("CS1591"); // Missing XML comment for publicly visible type or member 'Type_or_Member'

        foreach (var errorId in expectedErrorIds)
        {
            test.ExpectedDiagnostics.Add(
                DiagnosticResult.CompilerError(errorId).WithOptions(
                    DiagnosticOptions.IgnoreAdditionalLocations | DiagnosticOptions.IgnoreSeverity));
        }

        await test.RunAsync();
    }

    public static async Task CompileAsync(string fileName, params string[] expectedErrorIds) =>
        await CompileAsync(new string[] { fileName }, expectedErrorIds);

    //public static async Task CompileAsync(string[] expectedErrorIds, [CallerFilePath] string fileName = null!) =>
    //    await CompileAsync(new string[] { fileName }, expectedErrorIds);

    //public static async Task CompileAsync(string expectedErrorId, [CallerFilePath] string fileName = null!) =>
    //    await CompileAsync(new string[] { fileName }, new string[] { expectedErrorId });

    //Custom verifier to ignore diagnostic locations
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
#if NET7_0_OR_GREATER
                .WithPreprocessorSymbols("COMPILEERROR", "NET7_0_OR_GREATER")
#else
                .WithPreprocessorSymbols("COMPILEERROR")
#endif // NET7_0_OR_GREATER
            ;

        protected override IEnumerable<DiagnosticAnalyzer> GetDiagnosticAnalyzers()
            => Enumerable.Empty<DiagnosticAnalyzer>();
    }

    public static string GetSourceCodeFileName()
    {
        StackFrame CallStack = new(1, true);
        return Path.GetFileName(CallStack.GetFileName())??throw new InvalidOperationException(
            "File name is null");
    }
}
