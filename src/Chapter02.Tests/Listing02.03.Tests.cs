
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter02.Listing02_03.Tests;

[TestClass]
public class LiteralValueTests
{
    [TestMethod]
    public void Main_WriteNumbers()
    {
        string expected = $@"{1.6180339887498948M}";

        IntelliTect.TestTools.Console.ConsoleAssert.Expect(
            expected, Program.Main);
    }
}