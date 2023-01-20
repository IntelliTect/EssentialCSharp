using AddisonWesley.Michaelis.EssentialCSharp.Shared.Tests;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter06.Listing07_06.Tests;

[TestClass]
public class ProgramTests
{
    [TestMethod]
    public async Task PrivateMembersAreNotInheritedTests()
    {
        await CompilerAssert.CompileAsync(
            new string[] { "Listing07.06.PrivateMembersAreNotInherited.cs" },
            new string[] { "CS0122" });
    }
}