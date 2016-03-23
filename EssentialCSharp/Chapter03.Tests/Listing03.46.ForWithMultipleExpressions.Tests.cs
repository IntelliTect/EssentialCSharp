using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter03.Listing03_44.Tests
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void MainTest()
        {
            const string expected =
"0<5\t1<4\t2<3\t3>2\t4>1\t5>0\t";

            IntelliTect.ConsoleView.Tester.Test(
                expected, Program.Main);
        }
    }
}