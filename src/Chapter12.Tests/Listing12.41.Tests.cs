using AddisonWesley.Michaelis.EssentialCSharp.Shared.Tests;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter12.Listing12_41.Tests;

[TestClass]
public class Listing12
{
    [TestMethod]
    public async Task CannotConvertTypes()
    {
        await CompilerAssert.CompileTestTargetFileAsync(
            new string[] { "CS0030" });
    }
}
