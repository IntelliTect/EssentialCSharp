
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter02.Listing02_02.Tests;

[TestClass]
public class LiteralValueTests
{
    [TestMethod]
    public void Main_WriteNumbers()
    {
        string expected = $@"{1.618033988749895}";

        IntelliTect.TestTools.Console.ConsoleAssert.Expect(
            expected, Program.Main);
    }
}