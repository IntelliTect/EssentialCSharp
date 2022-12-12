using AddisonWesley.Michaelis.EssentialCSharp.Shared;
using AddisonWesley.Michaelis.EssentialCSharp.Shared.Tests;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter06.Listing07_08.Tests;

[TestClass]
public class ProgramTests
{
    [TestMethod]
    public async Task UnassignedVariableThrowsError()
    {
        await CompilerAssert.CompileAsync(
            new string[] { "Listing07.08.PreventingDerivationWithSealedClasses.cs" },
            new string[] { "CS0509" });
    }
}