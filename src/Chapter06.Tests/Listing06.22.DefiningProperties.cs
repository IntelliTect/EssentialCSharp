using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter06.Listing06_22.Tests
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void Main_CalculatedPropertySetGet_WriteGetterValue()
        {
            const string expected =
                @"Inigo Montoya";

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(
                expected, Program.Main);
        }
    }
}
