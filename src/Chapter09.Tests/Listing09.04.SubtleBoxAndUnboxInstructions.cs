using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter09.Listing09_04
{
    [TestClass]
    public class ProgramTests
    {

        [TestMethod]
        [ExpectedException(typeof(InvalidCastException))]
        public void AddToArrayIndexWithoutCasing()
        {
            string expected = "<<7>>";

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(
                expected, Program.Main);
        }

        [TestMethod]
        public void AddToArrayWithCasting()
        {
            const string OutputFormatString = @"Enter a number between 2 and 1000: <<{0}>>0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, 610, 987, 1597, 2584, 4181, 6765, 10946, 17711, 28657, 46368, 75025, 121393, 196418, 317811, 514229, 832040, 1346269, 2178309, 3524578, 5702887, 9227465, 14930352, 24157817, 39088169, 63245986, 102334155, 165580141, ";
            
            string expected = string.Format(OutputFormatString, 42);

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(
                expected, Program.Main);
        }
    }
}
