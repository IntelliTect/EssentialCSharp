using AddisonWesley.Michaelis.EssentialCSharp.Shared.Tests;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter07.Listing07_16.Tests;

[TestClass]
public class ProgramTests
{
    [TestMethod]
    public async Task DefiningAnAbstractClassTest()
    {
        await CompilerAssert.CompileTestTargetFileAsync(
            new string[] { "CS0144" });
    }
}
