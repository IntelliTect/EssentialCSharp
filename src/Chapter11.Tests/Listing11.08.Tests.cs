
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter11.Listing11_08.Tests;

[TestClass]
public class ProgramTests
{
    [TestMethod]
    public void MainTest()
    {
        const string expected = @"-2147483648";

        IntelliTect.TestTools.Console.ConsoleAssert.Expect(
            expected, Program.Main);
    }
}