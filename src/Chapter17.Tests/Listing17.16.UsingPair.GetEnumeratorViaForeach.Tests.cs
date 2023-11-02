
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter17.Listing17_16.Tests;

[TestClass]
public class ProgramTests
{
    [TestMethod]
    public void MainTest()
    {
        const string expected = @"Inigo
Montoya";

        IntelliTect.TestTools.Console.ConsoleAssert.Expect(
            expected, Program.Main);
    }
}
