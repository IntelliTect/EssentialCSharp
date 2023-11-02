
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter17.Listing17_02.Tests;

[TestClass]
public class ProgramTests
{
    [TestMethod]
    public void MainTest()
    {
        const string expected = @"Dwarf, Bashful
Dwarf, Doc
Dwarf, Dopey
Dwarf, Duplicate
Dwarf, Grumpy
Dwarf, Happy
Dwarf, Sleepy
Dwarf, Sneezy
Scarf, Duplicate";

        IntelliTect.TestTools.Console.ConsoleAssert.Expect(
            expected, Program.Main);
    }
}