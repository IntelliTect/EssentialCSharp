using System.Runtime.InteropServices;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter09.Listing09_38.Tests;

[TestClass]
public class ProgramTests
{
    [TestMethod]
    public void Main_FileAttributes_UseFlagsAttribute()
    {
        string expected = (RuntimeInformation.IsOSPlatform(OSPlatform.Windows) || RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
            ? @"""ReadOnly | Hidden"" outputs as ""ReadOnly, Hidden""
ReadOnly, Hidden"
            : @"""ReadOnly"" outputs as ""ReadOnly""
ReadOnly";

        IntelliTect.TestTools.Console.ConsoleAssert.Expect(
                expected, Program.Main);
    }
}
