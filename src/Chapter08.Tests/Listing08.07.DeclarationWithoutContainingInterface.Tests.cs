using AddisonWesley.Michaelis.EssentialCSharp.Shared.Tests;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter08.Listing08_07.Tests;

[TestClass]
public class ContactTests
{
    [TestMethod]
    public async Task DeclaringAMethodOnARelatedInterface_CompileError()
    {
        await CompilerAssert.CompileTestTargetFileAsync(
            new string[] { "CS0161", "CS0540" });
    }
}
