using AddisonWesley.Michaelis.EssentialCSharp.Shared.Tests;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter07.Listing07_08.Tests;

[TestClass]
public class ProgramTests
{
    [TestMethod]
    public async Task UnassignedVariableThrowsError()
    {
        await CompilerAssert.CompileAsync(
            new string[] { 
                CompilerAssert.GetSourceCodeFileName().Replace(
                    ".Tests","*") },
            new string[] { "CS0509" });
    }
}