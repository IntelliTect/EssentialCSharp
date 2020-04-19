using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter17.Listing17_01.Tests
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void UsingListOfT()
        {
            const string expected =
                "In alphabetical order Bashful is the first dwarf while Sneezy is the last.";

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(
                expected, Program.Main);
        }
    }
}