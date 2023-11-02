
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter23.Listing23_18.Tests;

[TestClass]
public class ProgramTests
{
    [TestMethod]
    public void MainTest()
    {
        const string expected = @"S5280ft = Smile  ";

        IntelliTect.TestTools.Console.ConsoleAssert.Expect(
            expected, Program.Main);
    }
}