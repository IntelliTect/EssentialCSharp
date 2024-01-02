
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter06.Listing06_44.Tests;

[TestClass]
public class ProgramTests
{
    [TestMethod]
    public void MainTest()
    {
        const string expected = """
            Inigo Montoya: ̫����
            Inigo Montoya: ̫����
            """;
        IntelliTect.TestTools.Console.ConsoleAssert.Expect(expected, () =>
        {
            Program.Main();
        });
    }
}
