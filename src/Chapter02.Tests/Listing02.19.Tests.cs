using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter02.Listing02_19.Tests
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void Main_WriteOverflowExample()
        {
            const string expected = "The age is: ";

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(
                expected, Program.Main);
        }
    }
}