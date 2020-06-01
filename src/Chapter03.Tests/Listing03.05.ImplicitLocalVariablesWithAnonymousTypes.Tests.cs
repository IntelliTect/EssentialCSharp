using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter03.Listing03_05

{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void Main_WriteInventions()
        {
            const string expected =
@"Bifocals (1784)
Phonograph (1877)";

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(
                expected, Program.Main);
        }
    }
}
