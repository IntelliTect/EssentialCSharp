using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter10.Listing10_12.Tests
{
    [TestClass]
    public class TextNumberParserTests
    {
        [TestMethod]
        public void Main_HospitalEmergencyCodes_DisplaysCodes()
        {
            const string expected =
                @"info: Console[0]
      Hospital Emergency Codes: = 'black', 'blue', 'brown', 'CBR', 'orange', 'purple', 'red', 'yellow'
warn: Console[0]
      This is a test of the emergency...";

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(
                expected, (Action<string[]>)(Program.Main), 
                new string[] { "black", "blue", "brown", "CBR", "orange", "purple", "red", "yellow" });
        }
    }
}