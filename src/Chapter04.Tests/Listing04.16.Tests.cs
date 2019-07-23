using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter04.Listing04_16.Tests
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void Main_PostIncrementInteger_ResultNotIncremented()
        {
            const string expected =
                @"result = 123 and count = 124";

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(
                expected, Program.Main);
        }
    }
}