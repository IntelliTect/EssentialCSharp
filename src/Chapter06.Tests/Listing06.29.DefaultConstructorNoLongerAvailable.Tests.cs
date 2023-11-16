using AddisonWesley.Michaelis.EssentialCSharp.Shared.Tests;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter06.Listing06_29.Tests;

[TestClass]
public class ProgramTests
{
    [TestMethod]
    public async Task UnassignedVariableThrowsError()
    {
        await CompilerAssert.CompileAsync(
            new string[] {
                CompilerAssert.GetTargetFileNameToCompileFromTestFileName(),
                "Listing06.28.DefiningAConstructor.cs" },
            ["CS7036"]);
    }
}
