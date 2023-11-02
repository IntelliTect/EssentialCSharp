
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter15.Listing15_01.Tests;

[TestClass]
public class ProgramTests
{
    [TestMethod]
    public void MainTest()
    {
        const string expected = @"Wealth without work
Pleasure without conscience
Knowledge without character
Commerce without morality
Science without humanity
Worship without sacrifice
Politics without principle";

        IntelliTect.TestTools.Console.ConsoleAssert.Expect(
            expected, Program.Main);
    }
}