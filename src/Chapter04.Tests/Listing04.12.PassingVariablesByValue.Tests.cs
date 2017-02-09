using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter04.Listing04_11.Tests
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void Main_WritePath()
        {
            string view = $"C:{Path.DirectorySeparatorChar}{Path.Combine("Data", "index.html")}";

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(view,
            () =>
            {
                Program.ChapterMain();
            });
        }
    }
}