using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter02.Listing02_06.Tests
{
    [TestClass]
    public class SingleQuoteTests
    {
        [TestMethod]
        public void Main_BooleanWritesAsDecimal()
        {
            const string expected = "42";

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(
                expected, Program.Main);
        }
    }
}