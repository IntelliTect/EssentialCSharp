using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter04.Listing04_50.Tests
{
    [TestClass]
    public class TicTacToeTests
    {
        [TestMethod]
        public void Main_BreakOnPlayerWinning_Player1Winner()
        {
            const string expected =
                @"Player 1 was the winner";

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(
                expected, TicTacToe.Main);
        }
    }
}