using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter02.Listing02_29.Tests
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void Main_TryParseStringValidNumber_CorrectlyParsed()
        {
            const string expected =
                @"Enter a number: <<42>>";

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(
                expected, Program.Main);
        }

        [TestMethod]
        public void Main_TryParseStringNonNumber_IncorrectInput()
        {
            const string expected =
@"Enter a number: <<forty-two
>>The text entered was not a valid number.";

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(
                expected, Program.Main);
        }
    }
}