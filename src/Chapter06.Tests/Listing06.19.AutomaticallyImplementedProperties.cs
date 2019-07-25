using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter06.Listing06_19.Tests
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void Main_AutoPropertySetterGetter_WriteGetterValue()
        {
            const string expected =
@"Inigo
Computer Nerd";

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(
                expected, Program.Main);
        }
    }
}
