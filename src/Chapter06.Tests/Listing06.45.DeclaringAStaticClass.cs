using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter06.Listing06_45.Tests
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void MainTest_ArgsHasZeroElements_ThrowException()
        {
            Assert.ThrowsException<ArgumentException>(
                () => Program.Main(new string[] { }));
        }

        [TestMethod]
        public void MainTest()
        {
            const string expected = @"Longest argument length = 10
Shortest argument length = 2";
            IntelliTect.TestTools.Console.ConsoleAssert.Expect(expected, () =>
                {
                    Program.Main(
                        new string[] {
                            "C#", "C++", "Java", "JavaScript", "COBOL" });
                });
        }
    }
}