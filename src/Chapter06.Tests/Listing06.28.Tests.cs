using AddisonWesley.Michaelis.EssentialCSharp.Shared.Tests;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter06.Listing06_28.Tests;

[TestClass]
public class ProgramTests
{
    [TestMethod]
    public async Task UnassignedVariableThrowsError()
    {
        await CompilerAssert.CompileAsync(
            new string[] {
                CompilerAssert.GetTargetFileNameToCompileFromTestFileName(),
                "Listing06.26.DefiningAConstructor.cs" },
            new string[] { "CS7036" });
    }
}