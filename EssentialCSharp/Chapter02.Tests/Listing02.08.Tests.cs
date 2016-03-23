using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter02.Listing02_08.Tests
{
    [TestClass]
    public class SingleQuoteTests
    {
        [TestMethod]
        public void Main_WriteSmiley()
        {
            const string expected =
@"'
:)";

            IntelliTect.ConsoleView.Tester.Test(
                expected, SingleQuote.Main);
        }
    }
}