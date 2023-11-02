
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter13.Listing13_24.Tests;

[TestClass]
public class ProgramTests
{
    [TestMethod]
    public void MainTest()
    {
        string expected = $@"Moe{Environment.NewLine}Larry{Environment.NewLine}Curly";

        IntelliTect.TestTools.Console.ConsoleAssert.Expect(
            expected, DoNotCaptureLoop.Main);
    }
}
