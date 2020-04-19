using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter05.Listing05_25.Tests
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void Main_HappyPath()
        {
            string expected = @"Enter your first name: <<Inigo
>>Enter your age: <<42
>>Hi Inigo!  You are 504 months old.
Goodbye Inigo";
            IntelliTect.TestTools.Console.ConsoleAssert.Expect(expected,
            () =>
            {
                ExceptionHandling.Main();
            });
        }

        [TestMethod]
        public void Main_GivenInvalidAge_ThrowException()
        {
            string expected = @"Enter your first name: <<Inigo
>>Enter your age: <<forty-two
>>The age entered ,forty-two, is not valid.
Goodbye Inigo";
            IntelliTect.TestTools.Console.ConsoleAssert.Expect(expected,
            () =>
            {
                ExceptionHandling.Main();
            });
        }
    }
}