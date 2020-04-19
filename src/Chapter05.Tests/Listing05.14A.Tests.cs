using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter05.Listing05_14A.Tests
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void MainTest()
        {
            const string expected = @"image[[]*]=Red
image[[]*]=Black";
            IntelliTect.TestTools.Console.ConsoleAssert.ExpectLike(expected, () =>
                {
                    Program.Main();
                });
        }
    }
}