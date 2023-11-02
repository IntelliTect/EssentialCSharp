
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter04.Listing04_35.Tests;

[TestClass]
public class ProgramTests
{
    [TestMethod]
    public void Main_LogicalNotOnFalseBool_WriteTrue()
    {
        const string expected =
            @"result = True";

        IntelliTect.TestTools.Console.ConsoleAssert.Expect(
            expected, Program.Main);
    }
}
