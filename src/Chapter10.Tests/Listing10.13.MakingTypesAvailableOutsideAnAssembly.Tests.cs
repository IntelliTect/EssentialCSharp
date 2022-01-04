using Chapter10.Tests.CustomTestAttributes;
using Chapter10.Tests.PowerShellTestsUtilities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using System.Runtime.InteropServices;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter10.Listing10_13.Tests
{
    [TestClass]
    public class TypeTests
    {

        [TestMethod]
        public void MakingTypesAvailableExternallyPS1_ExitCodeIs0()
        {
            if (PowerShellTestsUtilities.PowerShellNotInstalled()) Assert.Inconclusive("Powershell not installed");
            //EssentialCSharp\\src\\Chapter10.Tests\\bin\\Debug\\netcoreapp3.0
            string ps1Path = Path.GetFullPath("../../../../Chapter10/Listing10.13.MakingTypesAvailableExternally.ps1", Environment.CurrentDirectory);
            string traceValue = "0";

            string nameOfPowershellTool;
            if (PowerShellTestsUtilities.WindowsEnvironment()) nameOfPowershellTool = "powershell";
            else nameOfPowershellTool = "pwsh";

            System.Diagnostics.Process powerShell = System.Diagnostics.Process.Start(nameOfPowershellTool, $"-noprofile -command \"{ps1Path} {traceValue}\"");
            powerShell.WaitForExit();

            Assert.AreEqual(0, powerShell.ExitCode);
        }

        private static bool NotWindows()
        {
            return !RuntimeInformation.IsOSPlatform(OSPlatform.Windows);
        }

    }
}

