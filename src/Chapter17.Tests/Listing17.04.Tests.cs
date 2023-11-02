
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter17.Listing17_04.Tests;

[TestClass]
public class ProgramTests
{
    [TestMethod]
    public void MainTest()
    {
        const string expected = @"2
2";

        IntelliTect.TestTools.Console.ConsoleAssert.Expect(
            expected, Program.Main);
    }
}