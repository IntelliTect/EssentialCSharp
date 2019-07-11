using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter02.Listing02_30.Tests
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void Main_UsingTryParseWithInlineOut_Pi()
        {
            string expected = $"Enter a number: <<{System.Math.PI}>>input was parsed successfully to {System.Math.PI}.";

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(
                expected, Program.Main);

        }

        [TestMethod]
        public void Main_UsingTryParseWithInlineOut_Pie()
        {
            string expected = $"Enter a number: <<pie>>The text entered was not a valid number.";
            IntelliTect.TestTools.Console.ConsoleAssert.Expect(
                expected, Program.Main);

        }
    }
}