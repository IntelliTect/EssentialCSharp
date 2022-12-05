using AddisonWesley.Michaelis.EssentialCSharp.Shared.Tests;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter06.Listing06_28.Tests;

[TestClass]
public class ProgramTests
{
    [TestMethod]
    [Ignore]
    public async Task UnassignedVariableThrowsError()
    {
        await CompilerAssert.CompileAsync(
            new string[] { "Listing06.28.DefaultConstructorNoLongerAvailable.cs", "Listing06.26.DefiningAConstructor.cs" },
            new string[] { "CS7036" });
    }
}