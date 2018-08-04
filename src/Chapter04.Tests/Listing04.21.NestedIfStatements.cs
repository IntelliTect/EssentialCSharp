using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter04.Listing04_21.Tests
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void MainTest()
        {
            const string expected =
@"<<9>>What is the maximum number of turns in tic-tac-toe? (Enter 0 to exit.): Correct, tic-tac-toe has a maximum of 9 turns.";

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(
                expected, TicTacToeTrivia.Main);
        }
    }
}