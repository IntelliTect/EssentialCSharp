using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter04.Listing04_31.Tests
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void Main_InputIsEmpty_PlayerQuitConditionHit()
        {
            Program.input = "";
            Program.currentPlayer = "Inigo";
            
            const string expected =
                @"Player Inigo quit!!";

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(
                expected, Program.Main);
        }
        
        [TestMethod]
        public void Main_InputIsQuit_PlayerQuitConditionHit()
        {
            Program.input = "quit";
            Program.currentPlayer = "Inigo";
            
            const string expected =
                @"Player Inigo quit!!";

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(
                expected, Program.Main);
        }
    }
}