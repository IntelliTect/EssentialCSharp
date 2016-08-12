using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter16.Listing16_07a.Tests
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void SortedDictionaryOutputOrder()
        {
            string expected = string.Join(
                System.Environment.NewLine,
                "Error","Information", "Verbose", "Warning");

            Intellitect.ConsoleView.Tester.Test(expected,
            () =>
            {
                Program.ChapterMain();
            });
        }
    }
}