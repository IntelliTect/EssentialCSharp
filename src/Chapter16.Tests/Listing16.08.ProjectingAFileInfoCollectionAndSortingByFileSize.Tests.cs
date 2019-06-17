using IntelliTect.TestTools.Console;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter16.Listing16_08.Tests
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void ProjectionWithLinqsSelect()
        {
            // Required due to defect in MSTest that has the current directory
            // set to the MSTest executable directory, rather than the 
            // assembly directory. See https://github.com/Microsoft/vstest/issues/311
            Directory.SetCurrentDirectory(Path.GetDirectoryName(
                typeof(Program).GetTypeInfo().Assembly.Location));

            int expectedItemCount = Directory.EnumerateFiles(
                Directory.GetCurrentDirectory(), "*").Count();
            string expectedPattern = $@".{Path.DirectorySeparatorChar}*(*)";
            
            string output = IntelliTect.TestTools.Console.ConsoleAssert.Execute(null, () =>
            {
                Program.Main();
            });

            IEnumerable<string> outputItems = output.Split(
                new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);

            Assert.AreEqual(expectedItemCount, outputItems.Count());
            foreach (string item in outputItems)
            {
                Assert.IsTrue(item.IsLike(expectedPattern),
                    $"{item} is not like {expectedPattern}");
            }
        }
    }
}
