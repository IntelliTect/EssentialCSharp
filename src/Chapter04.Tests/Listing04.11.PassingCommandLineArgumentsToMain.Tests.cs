using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter04.Listing04_10.Tests
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void Main_NoArgs_ExpectErrors()
        {
            string[] args = new string[0];
            string view =
@"ERROR:  You must specify the URL and the file name
Usage: Downloader.exe <URL> <TargetFileName>";

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(view,
            () =>
            {
                Program.ChapterMain(args);
            });
        }

        [TestMethod]
        public void Main_GoodArgs_DownloadFile()
        {
            string[] args = { "http://google.com", Path.Combine(Directory.GetCurrentDirectory(), "destination.txt") };

            Assert.AreEqual(0, Program.ChapterMain(args));
        }
    }
}