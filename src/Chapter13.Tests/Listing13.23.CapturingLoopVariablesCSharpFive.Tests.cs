
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter13.Listing13_23.Tests;

[TestClass]
public class ProgramTests
{
    [TestMethod]
    public void MainTest()
    {
        string expected = $@"Moe{Environment.NewLine}Larry{Environment.NewLine}Curly";

        IntelliTect.TestTools.Console.ConsoleAssert.Expect(
            expected, CaptureLoop.Main);
    }
}
