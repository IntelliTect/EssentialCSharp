
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter12.Listing12_15.Tests;

[TestClass]
public class ProgramTests
{
    [TestMethod]
    public void MainTest()
    {
        const string expected = @"1914: Shackleton leaves for South Pole on ship Endurance";

        IntelliTect.TestTools.Console.ConsoleAssert.Expect(
            expected, Program.Main);
    }
}