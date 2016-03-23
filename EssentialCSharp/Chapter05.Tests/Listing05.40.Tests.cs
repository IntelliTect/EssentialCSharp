using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter05.Listing05_40.Tests
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod][ExpectedException(typeof(System.ArgumentException))]
        public void MainTest_ArgsHasZeroElements_ThrowException()
        {
            Program.Main(new string[] { });
        }

        [TestMethod]
        public void MainTest()
        {
            const string expected = @"Longest argument length = 10
Shortest argument length = 2";
            IntelliTect.ConsoleView.Tester.Test(expected, () =>
                {
                    Program.Main(
                        new string[] {
                            "C#", "C++", "Java", "JavaScript", "COBOL" });
                });
        }
    }
}