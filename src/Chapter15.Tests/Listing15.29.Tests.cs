
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter15.Listing15_29.Tests;

[TestClass]
public class ProgramTests
{
    [TestMethod]
    public void MainTest()
    {
        const string expected = @"{ TeamName = France, Players = System.String[] }
{ TeamName = Italy, Players = System.String[] }";

        IntelliTect.TestTools.Console.ConsoleAssert.Expect(
            expected, Program.Main);
    }
}