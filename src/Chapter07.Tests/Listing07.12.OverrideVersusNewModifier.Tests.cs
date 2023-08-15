using AddisonWesley.Michaelis.EssentialCSharp.Shared.Tests;
using Microsoft.VisualStudio.TestTools.UnitTesting;

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
    public async Task OverrideVersusNewModifier()
    {
        await CompilerAssert.CompileAsync(
            new string[] { $"{
                nameof(Listing07_12)
                    .Replace('_','.')}.{
                nameof(OverrideVersusNewModifier)}.cs" },
            new string[] { "CS0108" });
    }
}
