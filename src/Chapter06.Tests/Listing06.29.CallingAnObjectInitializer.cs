using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter06.Listing06_29.Tests
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void Main_ObjectInitializerSetTitleSalary_WriteEmployeeWithTitleSalary()
        {
            const string expected =
                @"Inigo Montoya (Computer Nerd): Not enough";

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(
                expected, Program.Main);
        }
    }
}
