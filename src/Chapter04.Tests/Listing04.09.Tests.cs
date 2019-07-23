using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter04.Listing04_09.Tests
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void Main_OverflowBoundsOfFloat_WriteInfinity()
        {
            const string expected =
@"-Infinity
Infinity";

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(
                expected, Program.Main);
        }
    }
}