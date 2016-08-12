using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.ComponentModel;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter10.Listing10_02A.Tests
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void MainTest()
        {
            Intellitect.ConsoleView.Tester.TestException(() => Program.ChapterMain(null), typeof(Win32Exception));
        }
    }
}