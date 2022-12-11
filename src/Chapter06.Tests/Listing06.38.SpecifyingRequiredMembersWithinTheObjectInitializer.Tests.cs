using AddisonWesley.Michaelis.EssentialCSharp.Shared.Tests;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter06.Listing06_38.Tests;

[TestClass]
public class ProgramTests
{
    [TestMethod]
    [Ignore]
    public async Task UnassignedVariableThrowsError()
    {
        await CompilerAssert.CompileAsync(
            new string[]{"Listing06.38.SpecifyingRequiredMembersWithinTheObjectInitializer.cs", "Listing06.37.RequiredProperties.cs"},
            new string[] { "CS9035" });
    }
}