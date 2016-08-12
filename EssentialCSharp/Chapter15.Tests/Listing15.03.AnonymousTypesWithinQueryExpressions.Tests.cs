using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter15.Listing15_03.Tests
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void ProjectionWithLinqsSelect()
        {
            string expected =
$@"({ Directory.GetCurrentDirectory().Replace("\\", "\\\\") }\\[0-9A-Za-z\.]+ \(\d+/\d+/\d+ \d+:\d+:\d+ (AM|PM)\)(\r\n)?)+";

            Intellitect.ConsoleView.Tester.AreLike(expected,
            () =>
            {
                Program.ChapterMain();
            });
        }
    }
}
