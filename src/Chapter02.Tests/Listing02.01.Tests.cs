using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter02.Listing02_01To06.Tests
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void Main_WriteNumbers()
        {
            const string netCoreApp2expected =
@"42
1.618034
1.61803398874989
1.618033988749895
6.023E+23
42
0x2A";

            const string netCoreApp3expected =
@"42
1.618034
1.618033988749895
1.618033988749895
6.023E+23
42
0x2A";
            string expected;
            string netCoreVersion = NetCore.GetNetCoreVersion();
            if(netCoreVersion.StartsWith("2.1"))
            {
                expected = netCoreApp2expected;
            }
            else if(netCoreVersion.StartsWith("3"))
            {
                expected = netCoreApp3expected;
            }
            else
            {
                throw new System.Exception(".NET Core Version ({netCoreVersion}) not handled.");
            }

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(
                    expected, Program.Main);
        }
    }
}