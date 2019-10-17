using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter04.Listing04_37.Tests
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void GivenSegmentsIsNull()
        {
            const string expected =
                @"There were no segments to combine.";

            Program.Segments = null;
            IntelliTect.TestTools.Console.ConsoleAssert.Expect(
                expected, Program.Main);
        }

        [TestMethod]
        public void GivenSegmentsEmpty()
        {
            const string expected =
                @"There were no segments to combine.";

            Program.Segments = new string[0];
            IntelliTect.TestTools.Console.ConsoleAssert.Expect(
                expected, Program.Main);
        }

        [TestMethod]
        public void GivenMultipleSegments()
        {
            const string expected =
                @"Uri: first/second/third";

            Program.Segments = new string[] { "first", "second", "third" };
            IntelliTect.TestTools.Console.ConsoleAssert.Expect(
                expected, Program.Main);
        }

        [TestMethod]
        public void MyTestMethod()
        {
            string? uri = null;

            if (uri is object thing)
            {
                System.Console.WriteLine(
                    $"Uri is: { thing }");
            }
            else // (uri is null)
            {
                System.Console.WriteLine(
                    "Uri is null");
            }

        }
    }
}