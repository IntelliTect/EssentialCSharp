
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter18.Listing18_29.Tests;

[TestClass]
public class ProgramTests
{
    [TestMethod]
    public void MainTest()
    {
        string expected = $@"Hello!  My name is Inigo Montoya
{140.6} makes for a long triathlon.";

        IntelliTect.TestTools.Console.ConsoleAssert.Expect(
            expected, Program.Main);
    }
}
