
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter06.Listing06_01.Tests;

[TestClass]
public class ProgramTests
{
    [TestMethod]
    public void MainTest()
    {
        const string expected = @"No output in this example";

        IntelliTect.TestTools.Console.ConsoleAssert.Expect(
            expected, Program.Main);
    }
}