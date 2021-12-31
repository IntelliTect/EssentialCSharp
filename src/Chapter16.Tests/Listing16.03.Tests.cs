using IntelliTect.TestTools.Console;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
using System.Reflection;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter16.Listing16_03.Tests
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void ProjectionWithLinqsSelect_TuplesWithinQueryExpressions()
        {
            ProgramTests.ProjectionWithLinqsSelect(Listing16_03.Program.Main);
        }

        public static void ProjectionWithLinqsSelect(Action mainAction)
        {
            int expectedItemCount = Directory.EnumerateFiles(
                Directory.GetCurrentDirectory(), "*").Count();
            string expectedPattern = $@"{ Directory.GetCurrentDirectory() }{Path.DirectorySeparatorChar}*(*)";

            string output = IntelliTect.TestTools.Console.ConsoleAssert.Execute(null, () =>
            {
                mainAction();
            });

            IEnumerable<string> outputItems = output.Split(
                Environment.NewLine.ToArray(), StringSplitOptions.RemoveEmptyEntries);

            Assert.AreEqual(expectedItemCount, outputItems.Count());
            foreach (string item in outputItems)
            {
                Assert.IsTrue(item.IsLike(expectedPattern));
            }
        }
    }
}
