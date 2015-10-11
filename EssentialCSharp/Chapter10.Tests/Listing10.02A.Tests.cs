using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter10.Listing10_02A.Tests
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod][ExpectedException(typeof(System.NullReferenceException))]
        public void MainTest()
        {
            const string expected = "";
            IntelliTect.ConsoleView.Tester.Test(expected,
                () =>
                {
                    Program.Main(null);
                });
        }
    }
}