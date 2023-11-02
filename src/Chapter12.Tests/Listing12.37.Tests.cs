
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter12.Listing12_37.Tests;

[TestClass]
public class ProgramTests
{
    [TestMethod]
    public void MainTest()
    {
        string expected = $@"490{Environment.NewLine}Fireswamp";

        IntelliTect.TestTools.Console.ConsoleAssert.Expect(
            expected, Program.Main);
    }
}