using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter04.Listing04_48.Tests
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void Main_Input4_ValidInput()
        {
            Program.input = "4";
            
            const string expected =
                @"";

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(
                expected, Program.Main);
        }
        
        [TestMethod]
        public void Main_Input0_InvalidInput()
        {
            Program.input = "0";
            
            const string expected =
@"
ERROR:  Enter a value from 1-9. Push ENTER to quit";

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(
                expected, Program.Main);
        }
        
        [TestMethod]
        public void Main_InputQuit_ExitProgram()
        {
            Program.input = "quit";
            
            const string expected =
                @"";

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(
                expected, Program.Main);
        }
    }
}