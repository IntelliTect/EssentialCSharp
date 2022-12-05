using AddisonWesley.Michaelis.EssentialCSharp.Shared.Tests;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter06.Listing06_35B.Tests
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        [Ignore]
        public async Task UnassignedVariableThrowsError()
        {
            await CompilerAssert.CompileAsync(
                new string[]{"Listing06.35B.SpecifyingRequiredMembersWithinTheObjectInitializer.cs", "Listing06.35A.RequiredProperties.cs"},
                new string[] { "CS9035" });
        }
    }
}