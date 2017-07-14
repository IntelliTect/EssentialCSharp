using IntelliTect.TestTools.Console;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter14.Listing14_17.Tests
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void ProjectionWithLinqsSelect()
        {
            string expectedPattern = "{ FileName = *, Size = * }";
            int expectedItemCount = Directory.EnumerateFiles(
                    Directory.GetCurrentDirectory(), "*").Count();
            string output = ConsoleAssert.Execute(null, () =>
            {
                Program.ChapterMain();
            });

            IEnumerable<string> outputItems = output.Split(
                new string[] { Environment.NewLine }, StringSplitOptions.None);

            Assert.AreEqual(expectedItemCount, outputItems.Count());
            foreach (string item in outputItems)
            {
                Assert.IsTrue(item.IsLike(expectedPattern),
                    $"{item} is not like {expectedPattern}");
            }
        }
    }
}
