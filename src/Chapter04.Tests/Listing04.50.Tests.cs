
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter04.Listing04_50.Tests;

[TestClass]
public class ProgramTests
{
    [TestMethod]
    public void ValidateAndMove_Input4_ValidInput()
    {
        const string expected =
            @"";

        int[] playerPositions = new int[1];
        int currentPlayer = 0;
        string input = "4";

        IntelliTect.TestTools.Console.ConsoleAssert.Expect(
            expected,
            _ => Program.ValidateAndMove(playerPositions, currentPlayer, input),
            true);
    }
    
    [TestMethod]
    public void ValidateAndMove_Input0_InvalidInput()
    {
        const string expected =
            @"错误:  输入1-9的值。 按Enter键退出。";

        int[] playerPositions = new int[1];
        int currentPlayer = 0;
        string input = "10";

        IntelliTect.TestTools.Console.ConsoleAssert.Expect(
            expected,
            _ => Program.ValidateAndMove(playerPositions, currentPlayer, input),
            false);
    }
    
    [TestMethod]
    public void ValidateAndMove_InputQuit_ExitProgram()
    {
        const string expected =
            @"";

        int[] playerPositions = new int[1];
        int currentPlayer = 0;
        string input = "quit";

        IntelliTect.TestTools.Console.ConsoleAssert.Expect(
            expected, 
            _ => Program.ValidateAndMove(playerPositions, currentPlayer, input), 
            true);
    }
}
