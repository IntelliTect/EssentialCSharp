using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter04.Listing04_05.Tests
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void Main_UseCharInArithmeticOperation_PrintCharacter()
        {
            const string expected =
                @"g";

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(
                expected, Program.Main);
        }
    }
}