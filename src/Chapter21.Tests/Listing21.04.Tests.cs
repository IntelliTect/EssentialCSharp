
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter21.Listing21_04.Tests;

[TestClass]
public class ProgramTests
{
    [TestMethod]
    public void MainTest()
    {
        const string expected = @"ERROR: AggregateException:
  UnauthorizedAccessException - Attempted to perform an unauthorized operation.*";

        IntelliTect.TestTools.Console.ConsoleAssert.ExpectLike(
            expected, Program.Main);
    }
}