using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter02.Listing02_06.Tests
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void Main_WriteDecimalAsHexidecimalUsingFormatSpecifier()
        {
            const string expected = "0x2A";

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(
                expected, Program.ChapterMain);
        }
    }
}