using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter03.Listing03_26.Tests
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void Main_GetLengthOfDimensionOf3DArray_ReturnsLength()
        {
            const string expected =
                "2";

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(
                expected, Program.Main);
        }
    }
}