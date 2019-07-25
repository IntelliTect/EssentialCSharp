using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter04.Listing04_28.Tests
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void Main_Input5_BooleanConditionHit()
        {
            const string expected =
                @"Tic-tac-toe has more than 5 maximum turns.";

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(
                expected, Program.Main);
        }
    }
}