using Chapter10.Tests.CustomTestAttributes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter10.Listing10_23.Tests
{
    [TestClass]
    public class DisposeTests
    {

        static string Ps1Path { get; } = Path.GetFullPath("../../../../Chapter10/Listing10.23.RegisteringAFinalizerWithProcessExit.ps1", Environment.CurrentDirectory);

        [ClassInitialize]
        public static void ClassInitialize(TestContext testContext)
        {
            string testStatus = "create";
            Process powershell = Process.Start("powershell", $"-noprofile -command \"{Ps1Path} 0 null {testStatus}\"");
            powershell.WaitForExit();
            var x= 0;
        }


        [ClassCleanup]
        public static void RemoveProcessExitProj()
        {
            string testStatus = "cleanup";
            Process powershell = Process.Start("powershell", $"-noprofile -command \"{Ps1Path} 0 null {testStatus}\"");
            powershell.WaitForExit();
        }



        [TestMethod]
        [TestMethodWithIgnoreIfSupport]
        [IgnoreIf(nameof(NotWindows))]


        [DataRow("", FinalizerRegisteredWithProcessExit, DisplayName = "Finalizer Registered With ProcessExit")]
        [DataRow("dispose", DisposeManuallyCalledExpectedOutput, DisplayName = "Dispose called before ProcessExit does finalizer")]
        [DataRow("gc", GCCalled, DisplayName = "Garbage Collected called")]
        public void MakingTypesAvailableExternallyPS1_ExitCodeIs0(string finalizerOrderOption, string expectedOutput)
        {
            //EssentialCSharp\\src\\Chapter10.Tests\\bin\\Debug\\netcoreapp3.0
            //string ps1Path = Path.GetFullPath("../../../../Chapter10/Listing10.23.RegisteringAFinalizerWithProcessExit.ps1", Environment.CurrentDirectory);
            string traceValue = "0";
            string testStatus = "run";

            var powershell = new Process();

            powershell.StartInfo.RedirectStandardOutput = true;
            powershell.StartInfo.FileName = "powershell";
            powershell.StartInfo.Arguments = $"-noprofile -command \"{Ps1Path} {traceValue} {finalizerOrderOption} {testStatus}\"";
            powershell.Start();

            // Process powershell = Process.Start("powershell", $"-noprofile -command \"{ps1Path} {traceValue} {finalizerOrderOption}\"");

            string psOutput = powershell.StandardOutput.ReadToEnd();
            powershell.WaitForExit();



            Assert.AreEqual(0, powershell.ExitCode);

            string programOutput = psOutput.Substring(psOutput.IndexOf("Main:"));

            Console.WriteLine(programOutput);

            Assert.AreEqual<string>(expectedOutput, programOutput);

            //System.Collections.IDictionary x = Environment.GetEnvironmentVariables();

            /*  foreach (object? y in x.Values)
              {
                  Console.WriteLine(y);
              }

              Console.WriteLine();*/
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

    }
}


