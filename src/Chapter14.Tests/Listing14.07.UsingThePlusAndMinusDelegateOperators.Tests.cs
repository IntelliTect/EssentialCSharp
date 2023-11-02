
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter14.Listing14_07.Tests;

[TestClass]
public class ProgramTests
{
    [TestMethod]
    public void MainTest()
    {
        string expected = $@"Combine delegates using + operator:{Environment.NewLine}Heater: Off{Environment.NewLine}Cooler: Off{Environment.NewLine}Uncombine delegates using - operator:{Environment.NewLine}Heater: Off";

        IntelliTect.TestTools.Console.ConsoleAssert.Expect(
            expected, Program.Main);
    }
}
