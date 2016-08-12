using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter01.Listing01_14.Tests
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void Main_InputOne_WriteOne()
        {
            const string expected = @"1<<1>>";

            Intellitect.ConsoleView.Tester.Test(
                expected, Program.ChapterMain);
        }
    }
}