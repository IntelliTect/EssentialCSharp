using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter20.Listing20_07.Tests
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void MainTest()
        {
            const string expected = @"";

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(
                expected, AsyncEncryptionCollection.Main);
        }
    }
}