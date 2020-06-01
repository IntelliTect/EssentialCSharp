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

            ConsoleAssert.Expect(expected, () => Program.Main(new[]
            {
                "black", "blue", "brown", "CBR",
                "orange", "purple", "red", "yellow"
            }));
        }
    }
}
