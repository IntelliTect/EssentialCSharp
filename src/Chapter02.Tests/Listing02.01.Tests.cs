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

            string expected = // netcoreapp3.0 and later
@"42
1.618034
1.618033988749895
1.618033988749895
6.023E+23
42
0x2A";

            string netCoreVersion = NetCore.GetNetCoreVersion();
            if (string.Compare(netCoreVersion, "3") < 0)
            {
                expected = netCoreApp2expected;
            }

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(
                    expected, Program.Main);

        }
    }
}