
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter15.Listing15_15.Tests;

[TestClass]
public class ProgramTests
{
    [TestMethod]
    public void MainTest()
    {
        string expected = $@"Patent Count: 8{Environment.NewLine}Patent Count in 1800s: 4";

        IntelliTect.TestTools.Console.ConsoleAssert.Expect(
            expected, Program.Main);
    }
}