using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter14.Listing14_04.Tests
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void DictionaryInitialization()
        {
            string expected = string.Join(System.Environment.NewLine,
                "Error","Warning", "Information", "Verbose");

            IntelliTect.ConsoleView.Tester.Test(expected,
            () =>
            {
                Program.Main();
            });
        }
    }
}