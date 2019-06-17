using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter02.Listing02_09.Tests
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void Main_WriteBooleanStatements()
        {
            const string netCoreApp2expected =
@"False: 1.61803398874989 == 1.61803398874989
True: 1.61803398874989 == 1.61803398874989";

            string expected = // netcoreapp3.0 and later
@"True: 1.618033988749895 == 1.618033988749895
True: 1.618033988749895 == 1.618033988749895";

            string netCoreVersion = NetCore.GetNetCoreVersion();
            if (string.Compare(netCoreVersion, "3")<0)
            {
                expected = netCoreApp2expected;
            }

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(
                    expected, Program.Main);
        }
    }
}