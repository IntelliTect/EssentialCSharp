using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter16.Listing16_07.Tests
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void DictionaryInitialization()
        {
            string expected = string.Join(
                System.Environment.NewLine,
                "Error","Warning", "Information", "Verbose");

            IntelliTect.ConsoleView.Tester.Test(expected,
            () =>
            {
                Program.Main();
            });
        }
    }
}