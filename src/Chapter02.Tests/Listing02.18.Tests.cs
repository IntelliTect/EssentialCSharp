
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter02.Listing02_18.Tests;

[TestClass]
public class SingleRawLiteralTests
{
    [TestMethod]
    public void Main_OutputsQuote()
    {
        const string expected = """Mama said, "Life was just a box of chocolates..." """;

        IntelliTect.TestTools.Console.ConsoleAssert.Expect(
            expected, Program.Main);
    }
}
