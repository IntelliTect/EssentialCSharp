using AddisonWesley.Michaelis.EssentialCSharp.Shared.Tests;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter04.Listing04_28.Tests;

[TestClass]
public class ProgramTests
{
    private static readonly string[] _ExpectedErrorIds = new string[] { "CS0103" };

    public static string[] ExpectedErrorIds => _ExpectedErrorIds;

    [TestMethod]
    public async Task CompileError_OutOfScope()
    {
        await CompilerAssert.CompileTestTargetFileAsync(ExpectedErrorIds);
    }
}
