using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter18.Listing18_05.Tests
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void ObservingUnhandeledExceptionsWithContinueWith()
        {
            string expected = @"Before
Starting...
Continuing A...
Continuing B...
Continuing C...
Finished!";

            //Intellitect.ConsoleView.Tester.Test(expected,
            //() =>
            //{
            //    Program.ChapterMain();
            //});
        }
    }
}