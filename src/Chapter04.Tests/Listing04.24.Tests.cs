using IntelliTect.TestTools.Console;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter04.Listing04_24.Tests;

[TestClass]
public class ProgramTests
{
    [TestMethod]
    public void Main_InputNegative1_ExitProgram()
    {
        const string expected =
            "Exiting";

        ConsoleAssert.Expect(
            expected, ()=>Program.Main("-1"));
    }

    [TestMethod]
    public void Main_Input10_ProgramDoesNotExit()
    {
        const string expected =
            "";

        ConsoleAssert.Expect(
            expected, ()=>Program.Main("10"));
    }

    [TestMethod]
    public void Main_Input0_ProgramDoesNotExit()
    {
        const string expected =
            "";

        ConsoleAssert.Expect(
            expected, () => Program.Main("0"));
    }
}
