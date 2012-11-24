using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter02.Listing02_11.Tests
{
    [TestClass]
    public class DuelOfWitsTests
    {
        [TestMethod]
        public void Main_WriteDizzyQuote()
        {
            string view = "\"Truly, you have a dizzying intellect.\"\n\"Wait 'til I get going!\"\n";

            IntelliTect.ConsoleView.Tester.Test(view,
            () =>
            {
                DuelOfWits.Main();
            });
        }
    }
}