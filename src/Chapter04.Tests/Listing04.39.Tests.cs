using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter04.Listing04_39.Tests
{
    [TestClass]
    public class Listing04_39_Tests
    {
        [TestMethod]
        public void Main_Negative7RightShiftBitwiseBy2()
        {
            const string expected =
                @"x = -2.";

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(
                expected, Program.Main);
        }
    }
}