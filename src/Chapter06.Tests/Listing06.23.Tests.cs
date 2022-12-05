using AddisonWesley.Michaelis.EssentialCSharp.Shared.Tests;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter06.Listing06_23.Tests
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public async Task UnassignedVariableThrowsError()
        {
            await CompilerAssert.CompileAsync(
                "Listing06.23.PlacingAccessModifiersOnSetters.cs",
                "CS0272");
        }
    }
}