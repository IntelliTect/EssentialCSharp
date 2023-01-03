using AddisonWesley.Michaelis.EssentialCSharp.Shared.Tests;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter06.Listing07_15.Tests;

[TestClass]
public class ProgramTests
{
    [TestMethod]
    public async Task InstantiatingDefiningAnAbstractClass()
    {
        await CompilerAssert.CompileAsync(
            new string[] { "Listing07.15.DefiningAnAbstractClass.cs" },
            new string[] { "CS0144" });
    }
}