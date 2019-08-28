using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter06.Listing06_17.Tests
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void Main_PropertySetterGetter_WriteProperty()
        {
            const string expected =
                @"Inigo";

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(
                expected, Program.Main);
        }
    }
}
