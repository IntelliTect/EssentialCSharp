
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter21.Listing21_02.Tests;

[TestClass]
public class ProgramTests
{
    [TestMethod]
    public void MainTest()
    {
        const string expected = @"3.1415926535897932384626433832795028841971693993751058209749445923078164062862089986280348253421170679";

        IntelliTect.TestTools.Console.ConsoleAssert.Expect(
            expected, Program.Main);
    }
}