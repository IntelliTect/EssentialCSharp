using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter04.Listing04_18.Tests
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void MainTest()
        {
            const string expected =
@"123, 124, 125
126, 127, 127";

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(
                expected, IncrementExample.Main);
        }
    }
}