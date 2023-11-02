
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter17.Listing17_21.Tests;

[TestClass]
public class ProgramTests
{
    [TestMethod]
    public void MainTest()
    {
        const string expected = @"Eagles
Redskins";

        IntelliTect.TestTools.Console.ConsoleAssert.Expect(
            expected, Program.Main);
    }
}
