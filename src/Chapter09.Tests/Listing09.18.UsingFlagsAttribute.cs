using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter09.Listing09_18.Tests
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void Main_FileAttributes_UseFlagsAttribute()
        {
            const string expected =
@"""ReadOnly"" outputs as ""ReadOnly""
ReadOnly";

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(
                expected, Program.Main);
        }
    }
}
