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
            const string expected =
                @"Exiting";

            ConsoleAssert.Expect(
                expected, ()=>Program.Main("8"));
        }

        [TestMethod]
        public void Main_Input10_ProgramDoesNotExit()
        {
            const string expected =
                "";

            ConsoleAssert.Expect(
                expected, ()=>Program.Main("10"));
        }
    }
}