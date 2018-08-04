using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter02.Listing02_17.Tests
{
    [TestClass]
    public class UppercaseTests
    {
        [TestMethod]
        public void Main_InputLorem_OutputNotCapitalized()
        {
            const string expected =
@"Enter text: <<Lorem
>>Lorem";

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(
                expected, Uppercase.Main);
        }
    }
}