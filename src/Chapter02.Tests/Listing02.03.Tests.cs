using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter02.Listing02_03.Tests
{
    [TestClass]
    public class LiteralValueTests
    {
        [TestMethod]
        public void Main_WriteNumbers()
        {
            const string expected = @"1.618033988749895";

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(
                expected, Program.Main);
        }
    }
}