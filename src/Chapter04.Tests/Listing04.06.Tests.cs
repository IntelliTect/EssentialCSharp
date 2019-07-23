using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter04.Listing04_06.Tests
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void Main_CharacterDistanceBetweenTwoCharacters_WriteIntegerDistance()
        {
            const string expected =
                @"3";

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(
                expected, Program.Main);
        }
    }
}