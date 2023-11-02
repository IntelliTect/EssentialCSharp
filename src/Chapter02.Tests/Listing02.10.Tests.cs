
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter02.Listing02_10.Tests;

[TestClass]
public class Comparison
{
    [TestMethod]
    public void Main_WriteBooleanStatements()
    {
        const string expected = "Help Requested: True";

        IntelliTect.TestTools.Console.ConsoleAssert.Expect(
            expected, Program.Main);
    }
}