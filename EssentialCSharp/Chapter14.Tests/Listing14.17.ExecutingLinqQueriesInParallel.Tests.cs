using Intellitect.ConsoleView;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter14.Listing14_17.Tests
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void ProjectionWithLinqsSelect()
        {
            string output = Tester.Execute(null, () =>
            {
                Program.ChapterMain();
            });

            IEnumerable<string> outputItems = output.Split('\n');

            Assert.AreEqual(10, outputItems.Count());
            foreach (string item in outputItems)
            {
                Assert.IsTrue(item.IsLike(@"{ FileName = [0-9A-Za-z\.]+, Size = \d+ }"));
            }
        }
    }
}
