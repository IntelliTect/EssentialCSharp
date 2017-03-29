using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter02.Listing02_30B.Tests
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void Main_WorkingWithTuples()
        {
            string expected = @"Sherlock Holme's address was:
221B Baker Street
Marylebone, London  NW1 6XE
England";
            expected += $"{System.Environment.NewLine + expected}";
            expected += $"{System.Environment.NewLine + expected}";

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(
                expected, Program.ChapterMain);

        }
    }
}