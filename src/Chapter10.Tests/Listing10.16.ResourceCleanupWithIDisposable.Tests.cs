
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter10.Listing10_16.Tests;

[TestClass]
public class SearchTests
{
    [TestMethod]
    public void MainTest()
    {
        const string expected = @"";

        IntelliTect.TestTools.Console.ConsoleAssert.Expect(
            expected, Program.Search);
    }
}
