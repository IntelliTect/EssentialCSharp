using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using System;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter05.Listing05_15.Tests;

[TestClass]
public class ProgramTests
{
    [TestMethod]
    public void Main_NoArgs_ExpectErrors()
    {
        string[] args = Array.Empty<string>();
        string expected = """
            ERROR:  You must specify the URL and the file name
            Usage: Downloader.exe <URL> <TargetFileName>
            """;

        IntelliTect.TestTools.Console.ConsoleAssert.Expect(expected,
        () =>
        {
            Program.Main(args);
        });
    }

    [TestMethod]
    public void Main_IntelliTectIndexHtmlArgs_DownloadFile()
    {
        try
        { 
            string[] args = { "http://IntelliTect.com", "Index.html" };
            string expected = $"Downloaded 'Index.html' from '{ args[0]}'.";

            int? result = null;
            IntelliTect.TestTools.Console.ConsoleAssert.Expect(
                expected, () => result = Program.Main(args));
        }
        catch (AggregateException exception) when (exception.InnerException is System.Net.Http.HttpRequestException)
        {
            Assert.Inconclusive("Unable to download the file.  Check your internet connection.");
        }
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
