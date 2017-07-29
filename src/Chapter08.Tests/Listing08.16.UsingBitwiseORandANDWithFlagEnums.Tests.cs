using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;


namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter08.Listing08_16.Tests
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void Main_ExpectHiddentAndReadOnlyFlags()
        {
            Directory.SetCurrentDirectory(AppContext.BaseDirectory);
            const string expected =
                @"Hidden | ReadOnly = 3";

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(
                expected, Program.Main);
            var text = nameof(AddisonWesley.Michaelis.EssentialCSharp.Chapter08.Listing08_16.Program.Main);
        }
    }
}