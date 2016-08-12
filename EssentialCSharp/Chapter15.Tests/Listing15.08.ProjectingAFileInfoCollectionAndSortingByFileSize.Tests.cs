using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter15.Listing15_08.Tests
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void ProjectionWithLinqsSelect()
        {
            string expected =
$@"(\.\\[0-9A-Za-z\.]+\(\d+\)(\r\n)?)+";

            Intellitect.ConsoleView.Tester.AreLike(expected,
            () =>
            {
                Program.ChapterMain();
            });
        }
    }
}
