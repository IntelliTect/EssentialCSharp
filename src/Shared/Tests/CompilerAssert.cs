using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.Diagnostics;
using Microsoft.CodeAnalysis.Testing;
using Microsoft.CodeAnalysis.Testing.Verifiers;
using System.Collections.Immutable;
using System.Runtime.CompilerServices;

namespace AddisonWesley.Michaelis.EssentialCSharp.Shared.Tests;

public static class CompilerAssert
{
    /// <summary>
    /// Compile the file associated with he caller's file name.
    /// </summary>
    /// <param name="expectedErrorIds">The id's of the expected errors and warnings. ex: CS0165</param>
    /// <returns>A task that is compiling the code.</returns>
    public static async Task CompileTestTargetFileAsync(
        string[] expectedErrorIds, [CallerFilePath] string testFileName = null!)
    {
        await CompileAsync(new string[] {
            GetTargetFileNameToCompileFromTestFileName(testFileName) }, 
            expectedErrorIds);
    }
    
    public static string GetTargetFileNameToCompileFromTestFileName(
        [CallerFilePath] string testFileName = null!)
    {
#if NET7_0_OR_GREATER
        ArgumentException.ThrowIfNullOrEmpty(testFileName);
#endif
        string targetFileToCompile = Path.GetFileName(testFileName.Replace(
                    ".Tests", "*"));
        return targetFileToCompile;
    }

    public static async Task CompileAsync(string[] fileNames, string[] expectedErrorIds)
    {

        Test test = new()
        {
            CompilerDiagnostics = CompilerDiagnostics.Warnings,
            ReferenceAssemblies = new ReferenceAssemblies(
                        $"net{Environment.Version.Major}.{Environment.Version.Minor}",
                        new PackageIdentity(
                            "Microsoft.NETCore.App.Ref",
                            NetCore.GetNetCoreVersion()),
                        Path.Combine("ref", $"net{Environment.Version.Major}.{Environment.Version.Minor}"))
        };

        List<string> fileNamesToCompile = new();
        foreach (string eachFileName in fileNames)
        {
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
                    fileNamesToCompile.Add(temp);
                }
                else if (currentTargetDirectory is not null)
                {
                    // Perhaps we have a wildcard in the file name.
                    fileNamesToCompile.AddRange(Directory.EnumerateFiles(
                        currentTargetDirectory,
                        eachFileName,
                        SearchOption.TopDirectoryOnly));
                }
                else
                {
                    throw new ArgumentException(
                        $"Specified file, {eachFileName} does not exist.", nameof(fileNames));
                }
            }
            else
            {
                fileNamesToCompile.Add(eachFileName);
            }
        }

        foreach (string fileName in fileNamesToCompile)
        {
            test.TestState.Sources.Add((Path.GetFileName(fileName), await File.ReadAllTextAsync(fileName)));
        }

        List<string> usingsToIgnore = new()
        {
            "Microsoft.VisualStudio.TestTools.UnitTesting"
        };

        // Note: GeneratedSources is ignored.
        string globalUsings = string.Join(Environment.NewLine,
        (await File.ReadAllLinesAsync("GlobalUsings.cs")).Where(usingLine => !usingsToIgnore.Any(t => usingLine.Contains(t))));
        test.TestState.Sources.Add(("GlobalUsings.cs", globalUsings));

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

    public static async Task CompileAsync(string fileName, string expectedErrorId) =>
    await CompileAsync(new string[] { fileName }, [expectedErrorId]);

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
                .WithPreprocessorSymbols(NetCore.GetAllValidNETPreprocessorSymbols().Append("COMPILEERROR"));

        protected override IEnumerable<DiagnosticAnalyzer> GetDiagnosticAnalyzers()
            => Enumerable.Empty<DiagnosticAnalyzer>();
    }
}
