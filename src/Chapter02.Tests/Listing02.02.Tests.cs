using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter02.Listing02_02.Tests
{
    [TestClass]
    public class LiteralValueTests
    {
        [TestMethod]
        [Ignore]
        public void Main_WriteNumbers()
        {
            const string expected = @"1.61803398874989";

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(
                expected, Program.Main);
        }
    }
}