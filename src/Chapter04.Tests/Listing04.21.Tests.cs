using IntelliTect.TestTools.Console;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter04.Listing04_21.Tests;

[TestClass]
public class TicTacToeTests
{
    [TestMethod]
    public void Main_Enter1TryToPlayAgainstComputer_ComputerPathSelected()
    {
        const string expected = """
                1 - �˻���ս
                2 - ˫�˶�ս
                ��ѡ��<<1
                >>Play against computer selected.
                """;

        ConsoleAssert.Expect(
            expected, TicTacToe.Main);
    }

    [TestMethod]
    public void Main_Enter2TryToPlayAgainstOtherPerson_TwoPlayerPathSelected()
    {
        const string expected =
@"1 - �˻���ս
2 - ˫�˶�ս
��ѡ��<<2
>>Play against another player.";

        ConsoleAssert.Expect(
            expected, TicTacToe.Main);
    }

    [TestMethod]
    public void Main_EnterOther_TwoPlayerPathSelected()
    {
        const string expected =
@"1 - �˻���ս
2 - ˫�˶�ս
��ѡ��<<9
>>Play against another player.";

        ConsoleAssert.Expect(
            expected, TicTacToe.Main);
    }
}
