using IntelliTect.TestTools.Console;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter04.Listing04_23.Tests
{
    [TestClass]
    public class Listing04_23_Tests
    {
        [TestMethod]
        public void Main_Input8_ExitProgram()
        {
            Program.input = 8;
            
            const string expected =
                @"Exiting";

            ConsoleAssert.Expect(
                expected, Program.Main);
        }

        [TestMethod]
        public void Main_Input10_ProgramDoesNotExit()
        {
            Program.input = 10;

            const string expected =
                "";

            ConsoleAssert.Expect(
                expected, Program.Main);
        }
    }
}