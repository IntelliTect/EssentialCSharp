
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter22.Listing22_09.Tests;

[TestClass]
public class ProgramTests
{
    [TestMethod]
    public void MainTest()
    {
        const string expected = @"ENTER to shut down";

        IntelliTect.TestTools.Console.ConsoleAssert.Expect(
            expected, Program.Main);
    }
}