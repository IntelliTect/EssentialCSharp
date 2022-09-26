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
<<<<<<< RefactorPowerShellTestUtilities
<<<<<<< RefactorPowerShellTestUtilities
            if (PowerShellTestUtilities.PowerShellNotInstalled) Assert.Inconclusive("Powershell not installed");
=======
            if (PowerShellTestsUtilities.PowerShellNotInstalled) Assert.Inconclusive("Powershell not installed");
>>>>>>> Added top level statement and refactored PowerShellTestsUtilities
=======
            if (PowerShellTestUtilities.PowerShellNotInstalled) Assert.Inconclusive("Powershell not installed");
>>>>>>> Minor rename of PowerShellTestUtilities
            //EssentialCSharp\\src\\Chapter10.Tests\\bin\\Debug\\netcoreapp3.0
            string ps1Path = Path.GetFullPath("../../../../Chapter10/Listing10.13.MakingTypesAvailableExternally.ps1", Environment.CurrentDirectory);
            string traceValue = "0";

<<<<<<< RefactorPowerShellTestUtilities
<<<<<<< RefactorPowerShellTestUtilities
            int exitCode = PowerShellTestUtilities.RunPowerShellScript(ps1Path, traceValue);
=======
            int exitCode = PowerShellTestsUtilities.RunPowerShellScript(ps1Path, traceValue);
>>>>>>> Added top level statement and refactored PowerShellTestsUtilities
=======
            int exitCode = PowerShellTestUtilities.RunPowerShellScript(ps1Path, traceValue);
>>>>>>> Minor rename of PowerShellTestUtilities
            
            Assert.AreEqual(0, exitCode);
        }
    }
}

