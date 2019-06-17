using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter04.Listing04_07.Tests
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void MainTest()
        {
            const string netCoreApp2expected =
@"4.2 != 4.2000002861023
4.2 != 4.20000028610229
(float)4.2M != 4.2F
4.20000028610229 != 4.2
4.2F != 4.2D
4.19999980926514 != 4.2
4.2F != 4.2D";

            string expected =
                @"4.2 != 4.2000002861023
4.2 != 4.200000286102295
(float)4.2M != 4.2000003F
4.200000286102295 != 4.2
4.2000003F != 4.2D
4.199999809265137 != 4.2
4.2F != 4.2D";

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