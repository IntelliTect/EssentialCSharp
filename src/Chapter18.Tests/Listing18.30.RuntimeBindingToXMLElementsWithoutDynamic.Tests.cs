
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter18.Listing18_30.Tests;

[TestClass]
public class ProgramTests
{
    [TestMethod]
    public void MainTest()
    {
        const string expected = @"InigoMontoya";

        IntelliTect.TestTools.Console.ConsoleAssert.Expect(
            expected, Program.Main);
    }
}
