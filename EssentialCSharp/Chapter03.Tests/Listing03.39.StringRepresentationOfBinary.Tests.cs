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
			string view =
				$@"Enter an integer: <<{integer}>>{System.Convert.ToString(integer, 10).PadLeft(64,'0')}";

            IntelliTect.ConsoleView.Tester.Test(view,
            () =>
            {
				BinaryConverter.Main();
            });
        }
    }
}


