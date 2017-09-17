using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter05.Listing05_32A.Tests
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void MainTest()
        {
            const string expected = @"Inigo Montoya: Too Little
Inigo Montoya: Too Little
Inigo Montoya: Too Little";
            IntelliTect.TestTools.Console.ConsoleAssert.Expect(expected, () =>
                {
                    Program.Main();
                });
        }
    }
}