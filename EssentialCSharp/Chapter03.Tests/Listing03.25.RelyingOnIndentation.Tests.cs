using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter03.Listing03_25.Tests
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void MainTest()
        {
            const string expected = 
@"The area of the circle is: 0.00";

            IntelliTect.ConsoleView.Tester.Test(
                expected, Program.Main);
        }
    }
}