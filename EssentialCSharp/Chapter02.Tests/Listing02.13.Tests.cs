using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter02.Listing02_13.Tests
{
    [TestClass]
    public class PalindromeLengthTests
    {
        [TestMethod]
        public void Main_InputRacecar_OutputPalindromeSevenChars()
        {
            string view =
@"Enter a palindrome: <<racecar
>>The palindrome, ""racecar"" is 7 characters.";

            IntelliTect.ConsoleView.Tester.Test(view,
            () =>
            {
                PalindromeLength.Main();
            });
        }
    }
}