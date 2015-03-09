using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter03.Listing03_02.Tests
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void MainTest()
        {
            string view = @"-18125876697430.99";

            IntelliTect.ConsoleView.Tester.Test(view,
            () =>
            {
                Program.Main();
            });
        }
    }
}