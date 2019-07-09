using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter02.Listing02_07.Tests
{
    [TestClass]
    public class LiteralValueTests
    {
        [TestMethod]
        public void Main_WriteBinary()
        {
            const string expected = "42";

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(
                expected, Program.Main);
        }
    }
}