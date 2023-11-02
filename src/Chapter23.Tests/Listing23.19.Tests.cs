
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter23.Listing23_19.Tests;

[TestClass]
public class ProgramTests
{
    [TestMethod]
    public void MainTest()
    {
        const string expected = "30° 18\' 0\"";

        IntelliTect.TestTools.Console.ConsoleAssert.Expect(
            expected, Program.Main);
    }
}