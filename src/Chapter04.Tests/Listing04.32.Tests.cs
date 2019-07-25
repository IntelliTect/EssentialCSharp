using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter04.Listing04_32.Tests
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void Main_Enter33ForHourOfDay_TimeInvalid()
        {
            Program.hourOfTheDay = 33;
            
            const string expected =
                @"The time you entered is invalid.";

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(
                expected, Program.Main);
        }
        
        [TestMethod]
        public void Main_EnterNegative1ForHourOfDay_TimeInvalid()
        {
            Program.hourOfTheDay = -1;
            
            const string expected =
                @"The time you entered is invalid.";

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(
                expected, Program.Main);
        }
    }
}