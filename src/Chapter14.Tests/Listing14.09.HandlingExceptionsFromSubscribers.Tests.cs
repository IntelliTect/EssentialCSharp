
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter14.Listing14_09.Tests;

[TestClass]
public class ProgramTests
{
    [TestMethod]
    public void MainTest()
    {
        const string expected = @"Enter temperature: '' is not a valid integer.";

        IntelliTect.TestTools.Console.ConsoleAssert.Expect(
            expected, Program.Main);
    }
}
