using AddisonWesley.Michaelis.EssentialCSharp.Shared.Tests;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter04.Listing04_28.Tests;

[TestClass]
public class ProgramTests
{
    private static readonly string[] ExpectedErrorIds = new string[] { "CS0103" };

    [TestMethod]
    public async Task CompileError_OutOfScope()
    {
        await CompilerAssert.CompileAsync($"Listing04.28.OutOfScope.cs", ExpectedErrorIds);
    }
}
