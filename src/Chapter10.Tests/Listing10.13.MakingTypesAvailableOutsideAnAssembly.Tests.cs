using AddisonWesley.Michaelis.EssentialCSharp.Shared.Tests;
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
            if (PowerShellTestUtilities.PowerShellNotInstalled) Assert.Inconclusive("Powershell not installed");
            //EssentialCSharp\\src\\Chapter10.Tests\\bin\\Debug\\netcoreapp3.0
            string ps1Path = Path.GetFullPath("../../../../Chapter10/Listing10.13.MakingTypesAvailableExternally.ps1", Environment.CurrentDirectory);
            string traceValue = "0";

            int exitCode = PowerShellTestUtilities.RunPowerShellScript(ps1Path, traceValue);

            Assert.AreEqual(0, exitCode);
        }
    }
}

