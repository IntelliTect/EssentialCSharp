using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter02.Listing02_05.Tests
{
    [TestClass]
    public class LiteralValueTests
    {
        [TestMethod]
        public void Main_WriteNumbers()
        {
            const string expected = @"6.023E+23";

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(
                expected, Program.Main);
        }
    }
}