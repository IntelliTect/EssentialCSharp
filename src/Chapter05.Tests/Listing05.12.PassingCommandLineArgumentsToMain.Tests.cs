using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using System;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter05.Listing05_12.Tests
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
                Program.Main(args);
            });
        }

        [TestMethod]
        public void Main_GoodArgs_DownloadFile()
        {
            string[] args = { "http://google.com", Path.Combine(Directory.GetCurrentDirectory(), "destination.txt") };

            try
            {
                Assert.AreEqual(0, Program.Main(args));
            }
            catch (AggregateException exception) when (exception.InnerException!.GetType() == typeof(System.Net.Http.HttpRequestException))
            {
                Assert.Inconclusive("Unable to download the file.  Check your Internet connection.");
            }
        }
    }
}