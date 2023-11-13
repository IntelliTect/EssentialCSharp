namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter04.Table04_01.Tests;

[TestClass]
public class ControlFlowStatementsTests
{
    [TestMethod]
    public void IfStatement_InputIsQuit_GameEnd()
    {
        const string input = "quit";
        const string expected = "Game end";

        IntelliTect.TestTools.Console.ConsoleAssert.Expect(
            expected, () => ControlFlowStatements.IfStatement(input));
    }

    [TestMethod]
    public void IfStatement_InputIsNotQuit_NoOutput()
    {
        const string input = "not quit";
        const string expected = "";

        IntelliTect.TestTools.Console.ConsoleAssert.Expect(
            expected, () => ControlFlowStatements.IfStatement(input));
    }

    [TestMethod]
    public void IfElseStatement_InputIsQuit_GameEnd()
    {
        const string input = "quit";
        const string expected = "Game end";

        IntelliTect.TestTools.Console.ConsoleAssert.Expect(
            expected, () => ControlFlowStatements.IfElseStatement(input));
    }

    [TestMethod]
    public void IfElseStatement_InputIsNotQuit_GetNextMove()
    {
        const string input = "don't quit game";
        const string expected = "Next move obtained.";

        IntelliTect.TestTools.Console.ConsoleAssert.Expect(
            expected, () => ControlFlowStatements.IfElseStatement(input));
    }

    [TestMethod]
    public void WhileStatement_CountIsLessThanTotal_CountIsLessThanTotal()
    {
        const int count = 0;
        const int total = 10;
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
        const string expected = "<<exit>>Enter name:";

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
        const int count = 0;
        const int total = 10;
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
        const string input = "exit";
        const string expected = "Exiting app....";

        IntelliTect.TestTools.Console.ConsoleAssert.Expect(
            expected, () => ControlFlowStatements.SwitchStatement(input));
    }

    [TestMethod]
    public void SwitchStatement_InputIsQuit_ExitApp()
    {
        const string input = "quit";
        const string expected = "Exiting app....";

        IntelliTect.TestTools.Console.ConsoleAssert.Expect(
            expected, () => ControlFlowStatements.SwitchStatement(input));
    }

    [TestMethod]
    public void SwitchStatement_InputIsRestart_RestartApp()
    {
        const string input = "restart";
        const string expected = @"Resetting app....
Next move obtained.";

        IntelliTect.TestTools.Console.ConsoleAssert.Expect(
            expected, () => ControlFlowStatements.SwitchStatement(input));
    }

    [TestMethod]
    public void SwitchStatement_InputIsStart_GetNextMove()
    {
        const string input = "start";
        const string expected = "Next move obtained.";

        IntelliTect.TestTools.Console.ConsoleAssert.Expect(
            expected, () => ControlFlowStatements.SwitchStatement(input));
    }

    [TestMethod]
    public void SwitchStatement_InputIsNotExitOrQuitOrRestart_NoOutput()
    {
        const string input = "default";
        const string expected = "default";

        IntelliTect.TestTools.Console.ConsoleAssert.Expect(
            expected, () => ControlFlowStatements.SwitchStatement(input));
    }
}