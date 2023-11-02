
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter02.Listing02_06.Tests;

[TestClass]
public class LiteralValueTests
{
    [TestMethod]
    public void Main_WriteHexadecimal()
    {
        const string expected = "42";

        IntelliTect.TestTools.Console.ConsoleAssert.Expect(
            expected, Program.Main);
    }
}