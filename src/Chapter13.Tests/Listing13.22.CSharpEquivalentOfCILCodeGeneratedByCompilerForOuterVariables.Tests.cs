
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter13.Listing13_22.Tests;

[TestClass]
public class ProgramTests
{
    [TestMethod]
    public void MainTest()
    {
        const string expected = @"Enter an integer: '' is not a valid integer.";

        IntelliTect.TestTools.Console.ConsoleAssert.Expect(
            expected, Program.Main);
    }
}
