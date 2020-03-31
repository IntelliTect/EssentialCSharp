using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using IntelliTect.TestTools.Console;
using Microsoft.VisualStudio.TestTools.UnitTesting;

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

            Action act = () => Program.Main(new[] {"black", "blue", "brown", "CBR", 
                "orange", "purple", "red", "yellow"});

            var result = Execute(act, true);
            
            Assert.AreEqual(expected, result);
        }

        private static string Execute(Action action, bool removeVT100 = false)
        {
            TextWriter savedOutputStream = Console.Out;
            try
            {
                string output;
                using (TextWriter writer = new StringWriter())
                {
                    Console.SetOut(writer);
                    action();

                    output = removeVT100 
                        ? RemoveVT100(RemoveAll(writer.ToString(), (char) 27))
                        : writer.ToString();
                }

                return output;
            }
            finally
            {
                Console.SetOut(savedOutputStream);
            }
        }

        private static string RemoveAll(string removeFrom, char toRemove)
        {
            var characters = removeFrom.ToCharArray().ToList();

            characters.RemoveAll(c => c == toRemove);

            return new string(characters.ToArray());
        }

        private static string RemoveVT100(string removeFrom)
        {
            return Regex.Replace(removeFrom, @"\[\d{1,2}m", "");
        }
    }
}