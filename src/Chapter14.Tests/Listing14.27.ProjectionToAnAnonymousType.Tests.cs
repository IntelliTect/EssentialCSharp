using IntelliTect.TestTools.Console;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Reflection;
using System;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter14.Listing14_30.Tests
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void ProjectionToAnAnonymousType()
        {
            // Required due to defect in MSTest that has the current directory
            // set to the MSTest executable directory, rather than the 
            // assembly directory.
            Directory.SetCurrentDirectory(Path.GetDirectoryName(
                typeof(Program).GetTypeInfo().Assembly.Location));

            string expectedPattern = "{ FileName = *, Size = * }";
            int expectedItemCount = Directory.EnumerateFiles(
                Directory.GetCurrentDirectory(), "*").Count();

            string output = ConsoleAssert.Execute(null, () =>
            {
                Program.Main();
            });

            IEnumerable<string> outputItems = output.Split(
                new string []{Environment.NewLine}, StringSplitOptions.None);

            Assert.AreEqual(expectedItemCount, outputItems.Count());
            foreach (string item in outputItems)
            {
                Assert.IsTrue(item.IsLike(expectedPattern),
                    $"{item} is not like {expectedPattern}");
            }
        }
    }
}
