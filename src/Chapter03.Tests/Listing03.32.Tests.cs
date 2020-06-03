using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter03.Listing03_32.Tests
{
    [TestClass]
    public class PalindromeTests
    {
        [TestMethod]    
        public void Main_InputValidPalindrome_IdentifiedAsPalindrome()
        {
            const string expected =
@"Enter a palindrome: <<kayak
>>""kayak"" is a palindrome.";

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(
                expected, Palindrome.Main);
        }
        
        [TestMethod]
        public void Main_InputInvalidPalindrome_NotIdentifiedAsPalindrome()
        {
            const string expected =
@"Enter a palindrome: <<test
>>""test"" is NOT a palindrome.";

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(
                expected, Palindrome.Main);
        }
    }
}