using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter03.Listing03_24.Tests
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void Main_GetCountOnArray_ReturnArrayLength()
        {
            const string expected =
                "There are 9 languages in the array.";

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(
                expected, Program.Main);
        }
    }
}