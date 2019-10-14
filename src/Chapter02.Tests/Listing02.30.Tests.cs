using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter02.Listing02_30.Tests
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void Main_UsingTryParseWithInlineOut_Pi()
        {
            string expected = $"Enter a number: <<{System.Math.PI}>>input was parsed successfully to {System.Math.PI}.>>{Environment.NewLine}'number' currently has the value: { System.Math.PI }";

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(
                expected, Program.Main);

        }

        [TestMethod]
        public void Main_UsingTryParseWithInlineOut_Pie()
        {
            string expected = @$"Enter a number: <<pie>>The text entered was not a valid number.
'number' currently has the value: { default(int) }";
            IntelliTect.TestTools.Console.ConsoleAssert.Expect(
                expected, Program.Main);

        }
    }
}