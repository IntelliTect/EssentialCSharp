using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter03.Listing03_18.Tests
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void MainTest()
        {
            const string expected =
@"123, 124, 125
126, 127, 127";

            IntelliTect.ConsoleView.Tester.Test(
                expected, IncrementExample.Main);
        }
    }
}