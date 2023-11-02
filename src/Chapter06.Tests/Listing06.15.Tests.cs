using AddisonWesley.Michaelis.EssentialCSharp.Shared.Tests;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter06.Listing06_15.Tests;

[TestClass]
public class ProgramTests
{
    [TestMethod]
    public async Task UnassignedVariableThrowsError()
    {
        await CompilerAssert.CompileTestTargetFileAsync(
            new string[] { "CS0122"});
    }
}