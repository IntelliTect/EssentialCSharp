using AddisonWesley.Michaelis.EssentialCSharp.Shared.Tests;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter10.Listing10_08.Tests;

[TestClass]
public class TypeTests
{

    [TestMethod]
    public void MakingTypesAvailableExternallyPS1_ExitCodeIs0()
    {
        if (PowerShellTestUtilities.PowerShellNotInstalled) Assert.Inconclusive("PowerShell not installed");

        string ps1Path = Path.Join(IntelliTect.Multitool.RepositoryPaths.GetDefaultRepoRoot(), "src", "Chapter10", "Listing10.08.MakingTypesAvailableExternally.ps1");
        string traceValue = "0";

        int exitCode = PowerShellTestUtilities.RunPowerShellScript(ps1Path, traceValue);

        Assert.AreEqual(0, exitCode);
    }
}

