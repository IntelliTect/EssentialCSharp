using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter04.Listing04_08.Tests
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void Main_DivideFloatBy0_WriteNaN()
        {
            const string expected =
                @"NaN";

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(
                expected, Program.Main);
        }
    }
}