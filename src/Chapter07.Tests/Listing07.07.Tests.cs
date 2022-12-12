using AddisonWesley.Michaelis.EssentialCSharp.Shared.Tests;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter06.Listing07_07.Tests;

[TestClass]
public class ProgramTests
{
    [TestMethod]
    public async Task ProtectedMembersInaccessibleFromNonDerivedTypes()
    {
        await CompilerAssert.CompileAsync(
            new string[] { "Listing07.07.ProtectedMembersAreAccessibleOnlyFromDerivedClasses.cs" },
            new string[] { "CS1540", "CS0122" });
    }
}