using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter04.Listing04_31.Tests
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void Main_InputIsEmpty_PlayerQuitConditionHit()
        {
            const string expected =
                @"Player Inigo quit!!";

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(
                expected, ()=>Program.Main("","Inigo"));
        }
        
        [TestMethod]
        public void Main_InputIsQuit_PlayerQuitConditionHit()
        {
            const string expected =
                @"Player Inigo quit!!";

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(
                expected, () => Program.Main("quit", "Inigo"));
        }
    }
}