using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter15.Listing15_07.Tests
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void ProjectionWithLinqsSelect()
        {
            string expected =
$@"({ Directory.GetCurrentDirectory().Replace("\\", "\\\\") }\\[0-9A-Za-z\.]+(\r\n)?)+";

            Intellitect.ConsoleView.Tester.AreLike(expected,
            () =>
            {
                Program.ChapterMain();
            });
        }
    }
}