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
            const string expected =
                @"Exiting...";

            ConsoleAssert.Expect(
                expected, ()=>Program.Main("-1"));
        }
        
        [TestMethod]
        public void Main_Input10_AnswerTooHigh()
        {
            const string expected = 
                @"Tic-tac-toe has less than 10 maximum turns.";

            ConsoleAssert.Expect(
                expected, ()=>Program.Main("10"));
        }
        
        [TestMethod]
        public void Main_Input5_AnswerTooLow()
        {
            const string expected = 
                @"Tic-tac-toe has more than 5 maximum turns.";

            ConsoleAssert.Expect(
                expected, ()=>Program.Main("5"));
        }

        [TestMethod]
        public void Main_Input9_CorrectAnswer()
        {
            const string expected = 
                @"Correct, tic-tac-toe has a maximum of 9 turns.";

            ConsoleAssert.Expect(
                expected, ()=>Program.Main("9"));
        }
    }
}