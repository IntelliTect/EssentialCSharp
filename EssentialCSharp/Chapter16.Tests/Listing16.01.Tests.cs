using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter16.Listing16_01.Tests
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void UsingListOfT()
        {
            const string expected =
                "In alphabetical order Bashful is the first dwarf while Sneezy is the last.";

            Intellitect.ConsoleView.Tester.Test(
                expected, Program.ChapterMain);
        }
    }
}