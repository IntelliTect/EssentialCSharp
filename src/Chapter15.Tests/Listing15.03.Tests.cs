
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter15.Listing15_03.Tests;

[TestClass]
public class ProgramTests
{
    [TestMethod]
    public void MainTest()
    {
        const string expected = @"1
2
3
4
5
6";

        IntelliTect.TestTools.Console.ConsoleAssert.Expect(
            expected, Program.Main);
    }
}