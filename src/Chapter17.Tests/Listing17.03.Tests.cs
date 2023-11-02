
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter17.Listing17_03.Tests;

[TestClass]
public class ProgramTests
{
    [TestMethod]
    public void MainTest()
    {
        const string expected = @"private
protected
protected internal
public";

        IntelliTect.TestTools.Console.ConsoleAssert.Expect(
            expected, Program.Main);
    }
}