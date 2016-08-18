using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter16.Listing16_11.Tests
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void IteratingAbinaryTree()
        {
            const string expected =
                @"John Francis Fitzgerald
Mary Josephine Hannon";

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(expected,
                Program.ChapterMain);
        }
    }
}