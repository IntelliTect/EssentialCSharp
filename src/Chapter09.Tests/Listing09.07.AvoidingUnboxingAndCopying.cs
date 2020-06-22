using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter09.Listing09_07
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void Main_AvoidingUnboxingAndCopying()
        {
            const string expected = @"2A";

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(
                expected, Program.Main);
        }
    }
}
