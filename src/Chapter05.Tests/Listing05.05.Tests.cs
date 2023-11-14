
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter05.Listing05_05.Tests;

[TestClass]
public class ProgramTests
{
    [TestMethod]
    public void Main_Quit_False()
    {
        string expected = "<<quit>>False";

        IntelliTect.TestTools.Console.ConsoleAssert.Expect(expected,
        () => Program.Main());
    }

    [TestMethod]
    public void Main_AnotherCommand_True()
    {
        string expected = "<<other>>True";

        IntelliTect.TestTools.Console.ConsoleAssert.Expect(expected,
        () => Program.Main());
    }
}
