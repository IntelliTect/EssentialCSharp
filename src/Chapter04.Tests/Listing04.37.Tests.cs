using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

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

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(
                expected, ()=>Program.Main(null!));
        }

        [TestMethod]
        public void GivenSegmentsEmpty()
        {
            const string expected =
                @"There were no segments to combine.";

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(
                expected, () => Program.Main(Array.Empty<string>()));
        }

        [TestMethod]
        public void GivenMultipleSegments()
        {
            const string expected =
                @"Uri: first/second/third";

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(
                expected, () => Program.Main(new[] { "first", "second", "third" }));
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