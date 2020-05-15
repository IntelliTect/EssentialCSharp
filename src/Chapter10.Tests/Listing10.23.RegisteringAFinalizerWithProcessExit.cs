using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter10.Listing10_23.Tests
{
    [TestClass]

    public class DisposeTests
    {

        static string Ps1Path { get; } = Path.GetFullPath("../../../../Chapter10/Listing10.23.RegisteringAFinalizerWithProcessExit.ps1", Environment.CurrentDirectory);
        static bool PowerShellIsInstalled = PowerShellInstalled();

        [ClassInitialize]
        public static void ClassInitialize(TestContext testContext)
        {
            if (!PowerShellIsInstalled) return;
            string testStatus = "create";
            Process powershell = Process.Start("powershell", $"-noprofile -command \"{Ps1Path} 0 null {testStatus}\"");
            powershell.WaitForExit();
        }


        [ClassCleanup]
        public static void RemoveProcessExitProj()
        {
            if (!PowerShellIsInstalled) return;
            string testStatus = "cleanup";
            Process powershell = Process.Start("powershell", $"-noprofile -command \"{Ps1Path} 0 null {testStatus}\"");
            powershell.WaitForExit();
        }

        [DataTestMethod]
        [DataRow("processExit", FinalizerRegisteredWithProcessExit, DisplayName = "Finalizer Registered With ProcessExit")]
        [DataRow("dispose", DisposeManuallyCalledExpectedOutput, DisplayName = "Dispose called before ProcessExit does finalizer")]
        [DataRow("gc", GCCalled, DisplayName = "Garbage Collected called")]
        public void FinalizerRunsAsPredicted_ConsoleOutputIsInOrder(string finalizerOrderOption, string expectedOutput)
        {
            if (!PowerShellIsInstalled) { Assert.Inconclusive("PowerShell Not Installed"); return; }

            string traceValue = "0";
            string testStatus = "run";

            var powershell = new Process();
            powershell.StartInfo.RedirectStandardOutput = true;
            powershell.StartInfo.FileName = "powershell";
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


        private static bool NotWindows()
        {
            return !RuntimeInformation.IsOSPlatform(OSPlatform.Windows);
        }

        public static bool PowerShellInstalled()
        {
            var environmentVariables = Environment.GetEnvironmentVariables().Values;

            foreach (string? value in environmentVariables)
            {
                if (!string.IsNullOrEmpty(value) && value.ToLower().Contains("powershell"))
                {
                    return true;
                }
            }
            return false;
        }

        public static string RemoveWhiteSpace(string str)
        {
            return Regex.Replace(str, @"\s+", String.Empty);
        }

    }




}


