using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter04.Listing04_20.Tests
{
    [TestClass]
    public class ExceptionHandlingTests
    {
        [TestMethod]
        public void Main_InputInvalidAge_ExpectInvalidMessage()
        {
            const string expected =
@"Enter your first name: <<Inigo
>>Enter your age: <<xyz
>>The age entered, xyz, is not valid.
Goodbye Inigo";

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(
                expected, ExceptionHandling.ChapterMain, 1);
        }


        [TestMethod]
        public void Main_InputFifty_ExpectSixHundredMonths()
        {
            const string expected =
@"Enter your first name: <<Inigo
>>Enter your age: <<50
>>Hi Inigo! You are 600 months old.
Goodbye Inigo";

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(
                expected, ExceptionHandling.ChapterMain);
        }
    }
}