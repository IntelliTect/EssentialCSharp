using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter01.Listing01_03.Tests
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void Main_InigoHello()
        {
            const string expected = @"Hello, My name is Inigo Montoya";

            IntelliTect.ConsoleView.Tester.Test(
                expected, Program.Main);
        }
    }
}