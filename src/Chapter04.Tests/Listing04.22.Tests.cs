using IntelliTect.TestTools.Console;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter04.Listing04_22.Tests
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void Main_InputOfNegative1_Exit()
        {
            Program.input = -1;

            const string expected =
                @"Exiting...";

            ConsoleAssert.Expect(
                expected, Program.Main);
        }
        
        [TestMethod]
        public void Main_Input10_AnswerTooHigh()
        {
            Program.input = 10;
            
            const string expected = 
                @"Tic-tac-toe has less than 10 maximum turns.";

            ConsoleAssert.Expect(
                expected, Program.Main);
        }
        
        [TestMethod]
        public void Main_Input5_AnswerTooLow()
        {
            Program.input = 5;
            
            const string expected = 
                @"Tic-tac-toe has more than 5 maximum turns.";

            ConsoleAssert.Expect(
                expected, Program.Main);
        }

        [TestMethod]
        public void Main_Input9_CorrectAnswer()
        {
            Program.input = 9;
            
            const string expected = 
                @"Correct, tic-tac-toe has a maximum of 9 turns.";

            ConsoleAssert.Expect(
                expected, Program.Main);
        }
    }
}