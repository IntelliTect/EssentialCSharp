using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter04.Listing04_47.Tests
{
    [TestClass]
    public class TicTacToeTests
    {
        [TestMethod]
        public void Main_DetermineRemainingMoves_WriteRemainingMoves()
        {
            const string expected =
                @"The available moves are as follows: 1 2 3 4 5 6 7 8 9 ";

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(
                expected, TicTacToe.Main);
        }
    }
}