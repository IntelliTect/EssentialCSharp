using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter06.Listing06_06.Tests
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void Main_AccessingFields_WriteFieldValues()
        {
            const string expected =
                @"Inigo Montoya: Enough to survive on";

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(
                expected, Program.Main);
        }
    }
}
