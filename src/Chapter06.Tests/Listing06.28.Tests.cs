using AddisonWesley.Michaelis.EssentialCSharp.Shared;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter06.Listing06_28.Tests
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        [Ignore]
        async public Task UnassignedVariableThrowsError()
        {
            await CompilerAssert.Compile2Async(
                new string[] { "Listing06.28.DefaultConstructorNoLongerAvailable.cs", "Listing06.26.DefiningAConstructor.cs" },
                new string[]{ "CS0246" });
        }
    }
}