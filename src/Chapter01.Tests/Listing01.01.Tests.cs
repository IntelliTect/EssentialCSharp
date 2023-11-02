using AddisonWesley.Michaelis.EssentialCSharp.Shared.Tests;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter01.Listing01_01.Tests;

[TestClass]
public class HelloWorldTests
{
    static string Ps1DirectoryPath { get; } =
        Path.GetFullPath(Path.Join(
            IntelliTect.Multitool.RepositoryPaths.GetDefaultRepoRoot(), "src", "Chapter01"));
    static string Ps1Path { get; } = 
        Path.GetFullPath(
            Path.Join(Ps1DirectoryPath, "Listing01.01.HelloWorldInC#.ps1"), Environment.CurrentDirectory);


    [TestMethod]
    public void CreateAndRunNewConsoleProject()
    {
        string traceLevel = "0";

        int exitCode = PowerShellTestUtilities.RunPowerShellScript(
           Ps1Path, $"{traceLevel}", out string psOutput);

        Assert.AreEqual(0, exitCode);

        // Check that the program successfully ran and 
        // produced the expected output.
        Assert.IsTrue(
            psOutput.Contains(
                $"{Environment.NewLine}Hello. My name is Inigo Montoya.{Environment.NewLine}"),
            "The expected HelloWorld output was not found.");

        // If the output is in English
        if (psOutput.Contains("Error(s)") && psOutput.Contains("Warning(s)"))
        {
            // Test that the program successfully produced the expected output.
            string[] expectedText = 
                {
                    "The template \"Console App\" was created successfully.",
                    "Build succeeded.",
                    "0 Error(s)",
                    "0 Warning(s)"
                };

            foreach (string text in expectedText)
            {
                Assert.IsTrue(psOutput.Contains(text),
                    $"Unexpectedly, '{text}' did not appear in the console output: {Environment.NewLine} {psOutput}");
            }
        }
    }

}
