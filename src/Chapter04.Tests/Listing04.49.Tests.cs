using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter04.Listing04_49.Tests
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void ValidateAndMove_Input4_ValidInput()
        {
            const string expected =
                @"";

            string[] args = {"0", "4"};

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(
                expected, HelperMethod, true, args);
        }
        
        [TestMethod]
        public void ValidateAndMove_Input0_InvalidInput()
        {
            const string expected =
@"
ERROR:  Enter a value from 1-9. Push ENTER to quit";
            
            string[] args = {"0", "10"};

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(
                expected, HelperMethod, false, args);
        }
        
        [TestMethod]
        public void ValidateAndMove_InputQuit_ExitProgram()
        {
            const string expected =
                @"";

            string[] args = {"0", "quit"};

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(
                expected, HelperMethod, true, args);
        }

        public bool HelperMethod(string[] args)
        {
            return Program.ValidateAndMove(null, int.Parse(args[0]), args[1]);
        }
    }
}