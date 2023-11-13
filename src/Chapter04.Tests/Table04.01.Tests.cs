namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter04.Table04_01.Tests;

[TestClass]
public class ControlFlowStatementsTests
{
    [TestMethod]
    public void IfStatement_InputIsQuit_GameEnd()
    {
        string input = "quit";
        string expected = "Game end";

        IntelliTect.TestTools.Console.ConsoleAssert.Expect(
            expected, () => ControlFlowStatements.IfStatement(input));
    }

    [TestMethod]
    public void IfStatement_InputIsNotQuit_NoOutput()
    {
        string input = "not quit";
        string expected = "";

        IntelliTect.TestTools.Console.ConsoleAssert.Expect(
            expected, () => ControlFlowStatements.IfStatement(input));
    }

    [TestMethod]
    public void IfElseStatement_InputIsQuit_GameEnd()
    {
        string input = "quit";
        string expected = "Game end";

        IntelliTect.TestTools.Console.ConsoleAssert.Expect(
            expected, () => ControlFlowStatements.IfElseStatement(input));
    }

    [TestMethod]
    public void IfElseStatement_InputIsNotQuit_GetNextMove()
    {
        string input = "don't quit game";
        string expected = "Next move obtained.";

        IntelliTect.TestTools.Console.ConsoleAssert.Expect(
            expected, () => ControlFlowStatements.IfElseStatement(input));
    }

    [TestMethod]
    public void WhileStatement_CountIsLessThanTotal_CountIsLessThanTotal()
    {
        int count = 0;
        int total = 10;
        string expected = "";
        for (int i = 0; i < total; i++)
        {
            expected += $"count = {i}{Environment.NewLine}";
        }

        IntelliTect.TestTools.Console.ConsoleAssert.Expect(
            expected, () => ControlFlowStatements.WhileStatement(count, total));
    }

    [TestMethod]
    public void DoWhileStatement_InputIsExit_ExitApp()
    {
        string expected = "<<exit>>Enter name:";

        IntelliTect.TestTools.Console.ConsoleAssert.Expect(
            expected, () => ControlFlowStatements.DoWhileStatement());
    }

    [TestMethod]
    public void DoWhileStatement_InputIsQuit_ExitApp()
    {
        string expected = @$"<<quit{Environment.NewLine}>>Enter name:
<<exit>>Enter name:";

        IntelliTect.TestTools.Console.ConsoleAssert.Expect(
            expected, () => ControlFlowStatements.DoWhileStatement());
    }

    [TestMethod]
    public void ForStatement_CountIsLessThanTotal_CountIsLessThanTotal()
    {
        int count = 0;
        int total = 10;
        string expected = "";
        for (int i = 0; i <= total; i++)
        {
            expected += $"count = {i}){Environment.NewLine}";
        }

        IntelliTect.TestTools.Console.ConsoleAssert.Expect(
            expected, () => ControlFlowStatements.ForStatement(count));
    }

    [TestMethod]
    public void SwitchStatement_InputIsExit_ExitApp()
    {
        string input = "exit";
        string expected = "Exiting app....";

        IntelliTect.TestTools.Console.ConsoleAssert.Expect(
            expected, () => ControlFlowStatements.SwitchStatement(input));
    }

    [TestMethod]
    public void SwitchStatement_InputIsQuit_ExitApp()
    {
        string input = "quit";
        string expected = "Exiting app....";

        IntelliTect.TestTools.Console.ConsoleAssert.Expect(
            expected, () => ControlFlowStatements.SwitchStatement(input));
    }

    [TestMethod]
    public void SwitchStatement_InputIsRestart_RestartApp()
    {
        string input = "restart";
        string expected = @"Resetting app....
Next move obtained.";

        IntelliTect.TestTools.Console.ConsoleAssert.Expect(
            expected, () => ControlFlowStatements.SwitchStatement(input));
    }

    [TestMethod]
    public void SwitchStatement_InputIsStart_GetNextMove()
    {
        string input = "start";
        string expected = "Next move obtained.";

        IntelliTect.TestTools.Console.ConsoleAssert.Expect(
            expected, () => ControlFlowStatements.SwitchStatement(input));
    }

    [TestMethod]
    public void SwitchStatement_InputIsNotExitOrQuitOrRestart_NoOutput()
    {
        string input = "default";
        string expected = "default";

        IntelliTect.TestTools.Console.ConsoleAssert.Expect(
            expected, () => ControlFlowStatements.SwitchStatement(input));
    }
}