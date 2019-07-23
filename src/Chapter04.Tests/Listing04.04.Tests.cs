using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter04.Listing04_04.Tests
{
    [TestClass]
    public class FortyTwoTests
    {
        [TestMethod]
        public void Main_AdditionOperatorWithNonNumericType_StringConcatenated()
        {
            const string expected = 
@"The original Tacoma Bridge in Washington
was brought down by a 42 mile/hour wind.";

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(
                expected, FortyTwo.Main);
        }
    }
}