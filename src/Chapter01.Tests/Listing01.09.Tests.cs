using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter01.Listing01_09.Tests
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void Main_HelloToInigo()
        {
            const string expected = @"Hello Inigo Montoya";

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(
                expected, Program.Main);
        }
    }
}