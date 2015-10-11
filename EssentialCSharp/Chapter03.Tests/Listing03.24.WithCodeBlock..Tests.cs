using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter03.Listing03_24.Tests
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void MainTest()
        {
            const string expected = 
@"Enter the radius of the circle: <<3
>>The area of the circle is: 28.27";

            IntelliTect.ConsoleView.Tester.Test(
                expected, CircleAreaCalculator.Main);
        }
    }
}