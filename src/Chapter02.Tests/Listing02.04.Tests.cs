using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter02.Listing02_04.Tests
{
    [TestClass]
    public class LiteralValueTests
    {
        [TestMethod]
        public void Main_WriteNumbers()
        {
            const string expected = @"9814072356";

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(
                expected, Program.Main);
        }
    }
}