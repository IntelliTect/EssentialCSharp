using AddisonWesley.Michaelis.EssentialCSharp.Shared.Tests;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter06.Listing06_32.Tests;

[TestClass]
public class ProgramTests
{
    [TestMethod]
    public async Task Main_CompileErrorCS8852()
    {
        await CompilerAssert.CompileAsync("Listing06.32.InitOnlySetters.cs", ["CS8852"]);
    }
}
