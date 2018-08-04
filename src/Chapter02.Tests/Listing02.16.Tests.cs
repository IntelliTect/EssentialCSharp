using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter02.Listing02_16.Tests
{
    [TestClass]
    public class PalindromeLengthTests
    {
        [TestMethod]
        public void Main_InputRacecar_OutputPalindromeSevenChars()
        {
            const string expected =
@"Enter a palindrome: <<racecar
>>The palindrome ""racecar"" is 7 characters.";

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(
                expected, PalindromeLength.Main);
        }
    }
}