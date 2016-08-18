using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter03.Listing03_02.Tests
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void MainTest()
        {
            const string expected = @"-18125876697430.99";

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(
                expected, Program.ChapterMain);
        }
    }
}