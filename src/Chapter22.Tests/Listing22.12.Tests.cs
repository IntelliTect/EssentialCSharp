
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter22.Listing22_12.Tests;

[TestClass]
public class ProgramTests
{
    [TestMethod]
    public void MainTest()
    {
        const string expected = @"Decrement Count = *
Main Count = *";

        IntelliTect.TestTools.Console.ConsoleAssert.ExpectLike(
            expected, Program.Main);
    }
}