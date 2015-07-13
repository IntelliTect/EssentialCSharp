using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter03.Listing03_39.Tests
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void MainTest()
        {
            int integer = new System.Random().Next();
            string expected =
                $@"Enter an integer: <<{integer}>>{System.Convert.ToString(integer, 2).PadLeft(64,'0')}";

            IntelliTect.ConsoleView.Tester.Test(
                expected, BinaryConverter.Main);
        }
    }
}


