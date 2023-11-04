using AddisonWesley.Michaelis.EssentialCSharp.Shared.Tests;

using System.Text.RegularExpressions;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter10.Listing10_18.Tests;

[TestClass]
public partial class DisposeTests
{
    private static Mutex Mutext { get; } = new (false, typeof(DisposeTests).FullName);

    public TestContext TestContext { get; set; } = null!; // Auto-initialized by MSTest.

    static string Ps1DirectoryPath { get; } =
        Path.GetFullPath(
            Path.Join(IntelliTect.Multitool.RepositoryPaths.GetDefaultRepoRoot(),"src", "Chapter10"));

    static string Ps1Path { get; } = 
        Path.GetFullPath(Path.Join(Ps1DirectoryPath, "Listing10.18.RegisteringAFinalizerWithProcessExit.ps1"), Environment.CurrentDirectory);

    private const string ProjectName = "ProcessExitTestProgram.testing";

    private static readonly object RunPowerShellScriptSyncLock = new();
    [ClassInitialize]
    public static void ClassInitialize(TestContext testContext)
    {
        try
        {
            Mutext.WaitOne();
            string psOutput;
            // Clean up at the start in case the class cleanup doesn't run (due to debug for example)
            string testStage = "cleanup";
            Assert.AreEqual<int>(0, RunPowerShellScript(testStage, out psOutput),
                $"Script failed with $testStage='{testStage}'. psOutput:\n{psOutput}");
            testStage = "create";
            int exitCode = RunPowerShellScript(testStage, out psOutput);
            Assert.AreEqual<int>(0, exitCode,
                $"Script failed with $testStage='{testStage}'. psOutput:\n{psOutput}");
            string projectFilePath =
                Path.Join(Ps1DirectoryPath, ProjectName, $"{ProjectName}.csproj");
            Assert.IsTrue(File.Exists(projectFilePath),
                $"The expected project file, '{projectFilePath}', was not created.");
        }
        finally
        {
            Mutext.ReleaseMutex();
        }
    }

    [ClassCleanup]
    public static void ClassCleanup()
    {
        // No return check since an exception here will be ignored.
        RunPowerShellScript("cleanup", out string _);
        Mutext.Dispose();
    }

    [DataTestMethod]
    [DataRow("processExit", FinalizerRegisteredWithProcessExit, DisplayName = "Finalizer Registered With ProcessExit")]
    [DataRow("dispose", DisposeManuallyCalledExpectedOutput, DisplayName = "Dispose called before ProcessExit does finalizer")]
    [DataRow("gc", GCCalled, DisplayName = "Garbage Collected called")]
    public void FinalizerRunsAsPredicted_ConsoleOutputIsInOrder(string finalizerOrderOption, string expectedOutput)
    {
        try
        {
            Mutext.WaitOne();
            int traceValue = 0;
            string testStatus = "run";

            TestContext.WriteLine($"Ps1Path = '{Path.GetFullPath(Ps1Path)}'");
            int exitCode = RunPowerShellScript(
                testStatus, finalizerOrderOption, traceValue, out string psOutput);

            Assert.AreEqual(0, exitCode, $"PowerShell Output: {psOutput}");

            Assert.AreEqual<string>(RemoveWhiteSpace(expectedOutput), RemoveWhiteSpace(psOutput),
                $"Unexpected output from '{Ps1Path} {traceValue} {finalizerOrderOption} {testStatus}:{Environment.NewLine}{psOutput}");
        }
        finally
        {
            Mutext.ReleaseMutex();
        }
    }

    private static int RunPowerShellScript(string testStage, out string psOutput) =>
        RunPowerShellScript(testStage, null, 0, out psOutput);
    private static int RunPowerShellScript(
        string testStage, string? finalizerOrderOption, int traceLevel, out string psOutput) => PowerShellTestUtilities.RunPowerShellScript(
                        Ps1Path, $"-TestStage {testStage} -FinalizerOption {finalizerOrderOption??"ignore"} {traceLevel}", out psOutput);

    public const string DisposeManuallyCalledExpectedOutput =
        """
        Main: Starting...
        DoStuff: Starting...
        SampleUnmanagedResource.ctor: Starting...
        SampleUnmanagedResource.ctor: Creating managed stuff...
        SampleUnmanagedResource.ctor: Creating unmanaged stuff...
        SampleUnmanagedResource.ctor: Exiting...
        Dispose: Starting...
        Dispose: Disposing managed stuff...
        Dispose: Disposing unmanaged stuff...
        Dispose: Exiting...
        DoStuff: Exiting...
        Main: Exiting...
        """;

    public const string FinalizerRegisteredWithProcessExit =
        """
        Main: Starting...
        DoStuff: Starting...
        SampleUnmanagedResource.ctor: Starting...
        SampleUnmanagedResource.ctor: Creating managed stuff...
        SampleUnmanagedResource.ctor: Creating unmanaged stuff...
        SampleUnmanagedResource.ctor: Exiting...
        DoStuff: Exiting...
        Main: Exiting...
        ProcessExitHandler: Starting...
        Dispose: Starting...
        Dispose: Disposing managed stuff...
        Dispose: Disposing unmanaged stuff...
        Dispose: Exiting...
        ProcessExitHandler: Exiting...
        """;

    public const string GCCalled =
        """
        Main: Starting...
        DoStuff: Starting...
        SampleUnmanagedResource.ctor: Starting...
        SampleUnmanagedResource.ctor: Creating managed stuff...
        SampleUnmanagedResource.ctor: Creating unmanaged stuff...
        SampleUnmanagedResource.ctor: Exiting...
        DoStuff: Exiting...
        Finalize: Starting...
        Dispose: Starting...
        Dispose: Disposing unmanaged stuff...
        Dispose: Exiting...
        Finalize: Exiting...
        Main: Exiting...
        """;

#if NET6_0
    public static string RemoveWhiteSpace(string str)
    {
        return Regex.Replace(str, @"\s+", String.Empty);
    }
#else
    [GeneratedRegex("\\s+")]
    private static partial Regex RemoveWhiteSpaceRegex();
    public static string RemoveWhiteSpace(string str)
    {
        return RemoveWhiteSpaceRegex().Replace(str, string.Empty);
    }
#endif
}
