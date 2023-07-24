namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter09.Listing09_27.Tests;

[TestClass]
public class ProgramTests
{
    [TestMethod]
    public void Main_BoxIdiosyncrasies()
    {
        const string expected = @"25, 25, 25, 26";

        IntelliTect.TestTools.Console.ConsoleAssert.Expect(
            expected, Program.Main);
    }
}
