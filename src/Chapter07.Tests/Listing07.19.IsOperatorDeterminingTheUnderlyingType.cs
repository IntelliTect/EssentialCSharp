using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter07.Listing07_19
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void SaveWithDataTest()
        {
            const string expected = "ENCRYPTED <data> ENCRYPTED";

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(
                expected,
                () => Program.Save("data")
            );
        }
    }
}
