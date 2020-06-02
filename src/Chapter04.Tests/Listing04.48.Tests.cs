using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter04.Listing04_48.Tests
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void Main_Input4_ValidInput()
        {
            const string expected =
                @"";

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(
                expected, () => Program.Main("4"));
        }
        
        [TestMethod]
        public void Main_Input0_InvalidInput()
        {
            const string expected =
@"
ERROR:  Enter a value from 1-9. Push ENTER to quit";

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(
                expected, () => Program.Main("0"));
        }
        
        [TestMethod]
        public void Main_InputQuit_ExitProgram()
        {
            const string expected =
                @"";

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(
                expected, () => Program.Main("quit"));
        }
    }
}