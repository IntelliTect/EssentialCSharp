
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter04.Listing04_02.Tests;

[TestClass]
public class ProgramTests
{
    [TestMethod]
    public void MainTest()
    {
        string expected = $@"{-72748555131730M}";

        IntelliTect.TestTools.Console.ConsoleAssert.Expect(
            expected, Program.Main);
    }
}