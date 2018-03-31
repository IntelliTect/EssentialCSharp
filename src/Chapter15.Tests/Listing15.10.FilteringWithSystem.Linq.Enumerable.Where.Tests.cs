using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter15.Listing15_10.Tests
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void FilteringWithSystem_Linq_Enumerable_Where()
        {
            string expected =
@"Phonograph (1877)
Kinetoscope (1888)
Electrical Telegraph (1837)
Steam Locomotive (1815)";

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(expected,
            () =>
            {
                Program.Main();
            });
        }
    }
}
