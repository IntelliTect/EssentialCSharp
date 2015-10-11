using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter01.Listing01_08.Tests
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void Main_HelloToInigo()
        {
            const string expected = @"Hello Inigo Montoya";

            IntelliTect.ConsoleView.Tester.Test(
                expected, Program.Main);
        }
    }
}