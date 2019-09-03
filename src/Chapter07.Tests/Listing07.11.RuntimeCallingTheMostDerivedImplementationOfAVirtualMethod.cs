using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter07.Listing07_11.Tests
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void Main_CallDerivedImplementation()
        {
            const string expected =
                @"Inigo Montoya";

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(
                expected, Program.Main);
        }
    }
}
