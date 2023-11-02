
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter03.Listing03_19.Tests;

[TestClass]
public class ProgramTests
{
    [TestMethod]
    public void Main_WriteInventions()
    {
        const string expected =
@"TypeScript
Python";

        IntelliTect.TestTools.Console.ConsoleAssert.Expect(
            expected, Program.Main);
    }
}
