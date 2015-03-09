using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter03.Listing03_03.Tests
{
    [TestClass]
    public class DivisionTests
    {
        [TestMethod]
        public void MainTest()
        {
            const string expected = @"Enter the numerator: <<42
>>Enter the denominator: <<5
>>42 / 5 = 8 with remainder 2";

            IntelliTect.ConsoleView.Tester.Test(
                expected, Division.Main);
        }
    }
}