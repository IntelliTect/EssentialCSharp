
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter17.Listing17_05.Tests;

[TestClass]
public class ProgramTests
{
    [TestMethod]
    public void MainTest()
    {
        const string expected = @"Error
Warning
Information
Verbose";

        IntelliTect.TestTools.Console.ConsoleAssert.Expect(
            expected, Program.Main);
    }
}