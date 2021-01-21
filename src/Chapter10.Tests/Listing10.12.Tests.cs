using IntelliTect.TestTools.Console;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using System;
using System.IO;
using System.Text.RegularExpressions;

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
      This is a test of the emergency...
";

            Action act = () => Program.Main(new[]
            {
                "black", "blue", "brown", "CBR",
                "orange", "purple", "red", "yellow"
            });

            string? result = Execute(act);

            Assert.AreEqual(expected, result);
        }

        private static string? Execute(Action action, bool removeVT100 = true)
        {
            TextWriter savedOutputStream = Console.Out;
            try
            {
                string? output;
                using TextWriter writer = new StringWriter();
                Console.SetOut(writer);
                action();

                output = removeVT100
                    ? RemoveVT100(writer.ToString()!)
                    : writer.ToString();

                return output;
            }
            finally
            {
                Console.SetOut(savedOutputStream);
            }
        }

        private static string RemoveVT100(string removeFrom)
        {
            return Regex.Replace(removeFrom, "\u001b\\[\\d{1,3}m", "");
        }
    }
}