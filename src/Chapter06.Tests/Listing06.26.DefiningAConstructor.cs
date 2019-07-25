using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter06.Listing06_26.Tests
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void Main_UsingAConstructor_WriteFirstNameLastNameSalary()
        {
            const string expected =
                @"Inigo Montoya: Too Little";

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(
                expected, Program.Main);
        }
    }
}
