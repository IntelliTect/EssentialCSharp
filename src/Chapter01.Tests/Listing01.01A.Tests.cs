using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Diagnostics;
using System.IO;
using AddisonWesley.Michaelis.EssentialCSharp.Shared.Tests;

using System.Text.RegularExpressions;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter01.Listing01_01A.Tests
{
    [TestClass]
    public class HelloWorldTests
    {
        static string Ps1Path { get; } = Path.GetFullPath("../../../../Chapter01/Listing01.01.HelloWorldInC#.ps1", Environment.CurrentDirectory);

        [TestMethod]
        public void CreateAndRunNewConsoleProject()
        {
            string traceLevel = "0";

            int exitCode = PowerShellTestUtilities.RunPowerShellScript(
               Ps1Path, $"{traceLevel}", out string psOutput);

            Assert.AreEqual(0, exitCode);

            // Test that the program successfully produced the expected output.
            string[] expectedText = {
                "The template \"Console App\" was created successfully.", 
                "Build succeeded.", 
                "0 Error(s)", 
                "0 Warning(s)",
                "Hello. My name is Inigo Montoya."
            };

            foreach (string text in expectedText)
            {
                Assert.IsTrue(psOutput.Contains(text),
                    $"Unexpectedly, '{text}' did not appear in the console output: \n {psOutput}");
            }
        }

    }
}
