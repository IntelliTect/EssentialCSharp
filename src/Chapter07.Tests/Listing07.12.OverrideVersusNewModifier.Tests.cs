using AddisonWesley.Michaelis.EssentialCSharp.Shared.Tests;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter07.Listing07_12.Tests;

[TestClass]
public class ProgramTests
{
    [TestMethod]
    public void Main_InheritanceTreeExample()
    {
        const string expected = """
                SuperSubDerivedClass
                SubDerivedClass
                SubDerivedClass
                BaseClass
                """;

        IntelliTect.TestTools.Console.ConsoleAssert.Expect(
            expected, Program.Main);
    }

    [TestMethod]
    public async Task OverrideVersusNewModifierTest()
    {
        await CompilerAssert.CompileTestTargetFileAsync(
            new string[] { "CS0108" });
    }
}
