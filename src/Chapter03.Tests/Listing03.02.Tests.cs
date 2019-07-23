using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter03.Listing03_02.Tests
{
    [TestClass]
    public class UppercaseTests
    {
        [TestMethod]
        public void Main_WriteInventions()
        {
            const string expected =
@"Enter text: <<test
>>TEST";

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(
                expected, Uppercase.Main);
        }
    }
}