
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter14.Listing14_06.Tests;

[TestClass]
public class ProgramTests
{
    [TestMethod]
    public void MainTest()
    {
        string expected = $@"Invoke both delegates:{Environment.NewLine}Heater: Off{Environment.NewLine}Cooler: On{Environment.NewLine}Invoke only delegate2{Environment.NewLine}Cooler: Off";

        IntelliTect.TestTools.Console.ConsoleAssert.Expect(
            expected, Program.Main);
    }
}
