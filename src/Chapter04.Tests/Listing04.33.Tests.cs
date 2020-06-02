using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter04.Listing04_33.Tests
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void Main_Enter25ForHourOfDay_AndConditionFails() // fulfills left side of AND but not right
        {
            const string expected =
                @"";

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(
                expected, () => Program.Main("25"));
        }

        [TestMethod]
        public void Main_Enter5ForHourOfDay_AndConditionFails() // fulfills right side of AND but not left
        {
            const string expected =
                @"";

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(
                expected, () => Program.Main("5"));
        }

        [TestMethod]
        public void Main_Enter22ForHourOfDay_AndConditionSatisfied() // fulfills both sides of AND
        {
            const string expected =
                @"Hi-Ho, Hi-Ho, it's off to work we go.";

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(
                expected, () => Program.Main("22"));
        }
    }
}