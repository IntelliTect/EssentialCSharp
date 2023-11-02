using AddisonWesley.Michaelis.EssentialCSharp.Shared.Tests;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter06.Listing07_07.Tests;

[TestClass]
public class ProgramTests
{
    [TestMethod]
    public async Task ProtectedMembersInaccessibleFromNonDerivedTypes()
    {
        await CompilerAssert.CompileTestTargetFileAsync(
            new string[] { "CS1540", "CS0122" });
    }
}