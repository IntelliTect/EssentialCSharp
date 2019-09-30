using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter10.Listing10_04.Tests
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void Main_ReferenceEqualsOnValueType_ReferencesNotEqual()
        {
            const string expected = "coordinate1 does NOT reference equal itself";

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(
                expected, Program.Main);
        }
    }
}
