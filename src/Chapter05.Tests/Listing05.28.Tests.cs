using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter05.Listing05_28.Tests
{
    [TestClass]
    public class LeveragingTryParseTests
    {
        public static int OutValue = 0;
        
        [TestMethod]
        public void Main_InputNameAndAge35_AgeProperlyParsed()
        {
            const string expected =
@"Enter your first name: <<Inigo
>>Enter your age: <<36
>>Hi Inigo! You are 432 months old.";

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(expected, 
                LeveragingTryParse.Main);
        }

        [TestMethod]
        public void Main_InputNameAndAgeThirtyFive_AgeNotParsed()
        {
            const string expected =
@"Enter your first name: <<Inigo
>>Enter your age: <<ThirtyFive
>>The age entered ,ThirtyFive, is not valid.";

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(
                expected, LeveragingTryParse.Main);
        }
    }
}