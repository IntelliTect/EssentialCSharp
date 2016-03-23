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
            string[] newLine = new string[] { };
            IEnumerable<string> expected =
@"{ FileName = Chapter14.exe, Size = 
{ FileName = Chapter14.pdb, Size = 
{ FileName = Chapter15.exe, Size = 
{ FileName = Chapter15.pdb, Size = 
{ FileName = Chapter15.Tests.dll, Size = 
{ FileName = Chapter15.Tests.pdb, Size = 
{ FileName = IntelliTect.Console.dll, Size = 
{ FileName = IntelliTect.Console.pdb, Size = ".Split(
    new string[] { Environment.NewLine }, StringSplitOptions.None);

            string output = IntelliTect.ConsoleView.Tester.Execute(null,
            () =>
            {
                Program.Main();
            });

            IEnumerable<string> outputItems = output.Split('\n');

            Assert.AreEqual(expected.Count(), outputItems.Count());
            foreach (string item in expected)
            {
                Assert.IsTrue(output.Contains(item));
            }
        }
    }
}