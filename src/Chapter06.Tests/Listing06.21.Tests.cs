using AddisonWesley.Michaelis.EssentialCSharp.Shared.Tests;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter06.Listing06_21.Tests
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public async Task UnassignedVariableThrowsError()
        {
            await CompilerAssert.CompileAsync(
                "Listing06.21.DefiningReadOnlyProperties.cs",
                "CS0200");
        }
    }
}