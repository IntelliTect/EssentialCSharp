
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter06.Listing06_44.Tests;

[TestClass]
public class ProgramTests
{
    [TestMethod]
    public void MainTest()
    {
        const string expected = """
            Inigo Montoya: 太少了
            Inigo Montoya: 太少了
            """;
        IntelliTect.TestTools.Console.ConsoleAssert.Expect(expected, () =>
        {
            Program.Main();
        });
    }
}
