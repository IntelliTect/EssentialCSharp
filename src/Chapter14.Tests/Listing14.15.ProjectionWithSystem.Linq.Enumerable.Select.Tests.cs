using IntelliTect.TestTools.Console;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter14.Listing14_15.Tests
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void Listing14_15_Test()
        {
            string expectedPattern = $@"{ Directory.GetCurrentDirectory() }{Path.DirectorySeparatorChar}*";

            string output = IntelliTect.TestTools.Console.ConsoleAssert.Execute(null, () =>
            {
                Program.ChapterMain();
            });

            IEnumerable<string> outputItems = output.Split('\n');

            Assert.AreEqual(6, outputItems.Count());
            foreach (string item in outputItems)
            {
                Assert.IsTrue(item.IsLike(expectedPattern));
            }
        }
    }
}