using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter03.Listing03_01.Tests
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void MainTest()
        {
            string view = @"2";

            IntelliTect.ConsoleView.Tester.Test(view,
            () =>
            {
				Program.Main();
            });
        }
    }
}