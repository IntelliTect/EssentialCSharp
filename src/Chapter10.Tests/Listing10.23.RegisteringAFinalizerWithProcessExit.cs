using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Diagnostics;
using System.IO;
using Chapter10.Tests.PowerShellTestsUtilities;
using System.Text.RegularExpressions;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter10.Listing10_23.Tests
{
    [TestClass]

    public class DisposeTests
    {

        static string Ps1Path { get; } = Path.GetFullPath("../../../../Chapter10/Listing10.23.RegisteringAFinalizerWithProcessExit.ps1", Environment.CurrentDirectory);
        static bool PowerShellNotAvailable = PowerShellTestsUtilities.PowerShellNotInstalled();
        static string PowershellEnvironmentVariableName { get; set; } = "powershell";

        [ClassInitialize]
        public static void ClassInitialize(TestContext testContext)
        {
            if (PowerShellNotAvailable) { Assert.Inconclusive("Powershell not installed"); return; }
            
            if (PowerShellTestsUtilities.WindowsEnvironment()) PowershellEnvironmentVariableName = "powershell";
            else PowershellEnvironmentVariableName = "pwsh";
            
            string testStatus = "create";
            Process powershell = Process.Start(PowershellEnvironmentVariableName, $"-noprofile -command \"{Ps1Path} 0 null {testStatus}\"");
            powershell.WaitForExit();
        }


        [ClassCleanup]
        public static void RemoveProcessExitProj()
        {
            if (PowerShellNotAvailable) { return; }
            string testStatus = "cleanup";
            Process powershell = Process.Start(PowershellEnvironmentVariableName, $"-noprofile -command \"{Ps1Path} 0 null {testStatus}\"");
            powershell.WaitForExit();
        }

        [DataTestMethod]
        [DataRow("processExit", FinalizerRegisteredWithProcessExit, DisplayName = "Finalizer Registered With ProcessExit")]
        [DataRow("dispose", DisposeManuallyCalledExpectedOutput, DisplayName = "Dispose called before ProcessExit does finalizer")]
        [DataRow("gc", GCCalled, DisplayName = "Garbage Collected called")]
        public void FinalizerRunsAsPredicted_ConsoleOutputIsInOrder(string finalizerOrderOption, string expectedOutput)
        {
            if (PowerShellNotAvailable) { Assert.Inconclusive("Powershell not installed"); return; }

            string traceValue = "0";
            string testStatus = "run";

            var powershell = new Process();
            powershell.StartInfo.RedirectStandardOutput = true;
            powershell.StartInfo.FileName = PowershellEnvironmentVariableName;
            powershell.StartInfo.Arguments = $"-noprofile -command \"{Ps1Path} {traceValue} {finalizerOrderOption} {testStatus}\"";
            powershell.Start();
            string psOutput = powershell.StandardOutput.ReadToEnd();
            powershell.WaitForExit();

            Assert.AreEqual(0, powershell.ExitCode);

            Assert.AreEqual<string>(RemoveWhiteSpace(expectedOutput), RemoveWhiteSpace(psOutput));

        }


        public const string DisposeManuallyCalledExpectedOutput =
            @"Main: Starting...
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
            Main: Exiting...";

        public const string FinalizerRegisteredWithProcessExit =
            @"Main: Starting...
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
            ProcessExitHandler: Exiting...";

        public const string GCCalled =
            @"Main: Starting...
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
            Main: Exiting...";


      

        public static string RemoveWhiteSpace(string str)
        {
            return Regex.Replace(str, @"\s+", String.Empty);
        }

    }




}


