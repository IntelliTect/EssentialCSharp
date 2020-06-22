using System.Runtime.InteropServices;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter09.Listing09_17
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void Main_FileAttributes_UseFlagsAttribute()
        {
            string expected = RuntimeInformation.IsOSPlatform(OSPlatform.Windows)
                ? @"""ReadOnly | Hidden"" outputs as ""ReadOnly, Hidden""
ReadOnly, Hidden"
                : @"""ReadOnly"" outputs as ""ReadOnly""
ReadOnly";

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(
                    expected, Program.Main);
        }
    }
}
