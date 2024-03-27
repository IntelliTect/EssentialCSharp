
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter22.Listing22_10.Tests;

[TestClass]
public class ProgramTests
{
    [TestMethod]
    public void MainTest()
    {
        const string expected = @"Application started....
Starting task....
DoWork() started....
Waiting while task executes...
DoWork() ending....
Task completed
Application shutting down....";

        IntelliTect.TestTools.Console.ConsoleAssert.Expect(
            expected, Program.Main);
    }
}