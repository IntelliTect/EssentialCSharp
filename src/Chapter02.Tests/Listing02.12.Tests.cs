using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter02.Listing02_12.Tests
{
    [TestClass]
    public class SingleQuoteTests
    {
        [TestMethod]
        public void Main_WriteSmiley()
        {
            const string expected =
@":)";

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(
                expected, SingleQuote.Main);
        }
    }
}