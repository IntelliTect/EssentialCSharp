
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter18.Listing18_31.Tests;

[TestClass]
public class ProgramTests
{
    [TestMethod]
    public void MainTest()
    {
        const string expected = @"Inigo Montoya";

        IntelliTect.TestTools.Console.ConsoleAssert.Expect(
            expected, Program.Main);
    }
}
