
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter19.Listing19_06.Tests;

[TestClass]
public class ProgramTests
{
    [TestMethod]
    public void MainTest()
    {
        const string expected = @"ERROR: Operation is not valid due to the current state of the object.";

        IntelliTect.TestTools.Console.ConsoleAssert.Expect(
            expected, Program.Main);
    }
}