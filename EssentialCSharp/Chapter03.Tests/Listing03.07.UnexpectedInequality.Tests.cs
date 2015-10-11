using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter03.Listing03_07.Tests
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void MainTest()
        {
            const string expected = 
                @"4.2 != 4.20000006258488
4.2 != 4.20000006258488
(float)4.2M != 4.2F
4.20000006258488 != 4.20000028610229
4.20000006258488 != 4.2
4.2F != 4.2D
4.19999980926514 != 4.2
4.2F != 4.2D";

            IntelliTect.ConsoleView.Tester.Test(
                expected, Program.Main);
        }
    }
}