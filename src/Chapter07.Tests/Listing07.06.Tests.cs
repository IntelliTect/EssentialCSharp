using AddisonWesley.Michaelis.EssentialCSharp.Shared;
using AddisonWesley.Michaelis.EssentialCSharp.Shared.Tests;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter06.Listing07_06.Tests;

[TestClass]
public class ProgramTests
{
    [TestMethod]
    [Ignore]
    public async Task UnassignedVariableThrowsError()
    {
        await CompilerAssert2.Compile2Async(
            new string[] { "Listing07.06.PrivateMembersAreNotInherited.cs" },
            new string[] { "CS0122" });
    }
}