using IntelliTect.TestTools.Console;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter04.Listing04_20.Tests
{
    [TestClass]
    public class TicTacToeTests
    {
        [TestMethod]
        public void Main_Enter1TryToPlayAgainstComputer_ComputerPathSelected()
        {
            const string expected =
@"1 - Play against the computer
2 - Play against another player.
Choose:<<1
>>Play against computer selected.";

            ConsoleAssert.Expect(
                expected, TicTacToe.Main);
        }

        [TestMethod]
        public void Main_Enter2TryToPlayAgainstOtherPerson_TwoPlayerPathSelected()
        {
            const string expected =
@"1 - Play against the computer
2 - Play against another player.
Choose:<<2
>>Play against another player.";

            ConsoleAssert.Expect(
                expected, TicTacToe.Main);
        }

        [TestMethod]
        public void Main_EnterOther_TwoPlayerPathSelected()
        {
            const string expected =
@"1 - Play against the computer
2 - Play against another player.
Choose:<<9
>>Play against another player.";

            ConsoleAssert.Expect(
                expected, TicTacToe.Main);
        }
    }
}