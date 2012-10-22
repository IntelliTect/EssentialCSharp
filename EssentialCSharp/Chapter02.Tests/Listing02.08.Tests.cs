using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter02.Listing02_08.Tests
{
    [TestClass]
    public class SingleQuoteTests
    {
        [TestMethod]
        public void Main_WriteSmiley()
        {
            string view =
@"'
:)";

            IntelliTect.ConsoleView.Tester.Test(view,
            () =>
            {
                SingleQuote.Main();
            });
        }
    }
}