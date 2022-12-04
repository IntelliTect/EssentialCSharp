using AddisonWesley.Michaelis.EssentialCSharp.Shared;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter06.Listing06_28.Tests
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public async Task UnassignedVariableThrowsError()
        {
            await CompilerAssert2.Compile2Async(
                new string[] { "Listing06.28.DefaultConstructorNoLongerAvailable.cs", "Listing06.26.DefiningAConstructor.cs" },
                new string[]{ "CS7036" });
        }
    }
}