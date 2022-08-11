using Microsoft.VisualStudio.TestTools.UnitTesting;
using AddisonWesley.Michaelis.EssentialCSharp.Shared;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter04.Listing04_07.Tests
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void MainTest()
        {
            string netCoreApp3expected =
$@"{(decimal)4.2} != {(decimal)4.2000002861023}
{(double)4.2} != {(double)4.20000028610229}
(float){(float)4.2}M != {(float)4.2}F
{(double)4.20000028610229} != {(double)4.2}
{(float)4.2}F != {(double)4.2D}D
{(double)4.19999980926514F} != {4.2D}
{4.2F}F != {4.2D}D";

            string expected =
                $@"{(decimal)4.2} != {(decimal)4.2000002861023}
{(double)4.2} != {(double)4.200000286102295}
(float){(float)4.2}M != {(float)4.2000003}F
{(double)4.200000286102295} != {(double)4.2}
{(float)4.2000003}F != {(double)4.2}D
{(double)4.199999809265137F} != {4.2D}
{4.2F}F != {4.2D}D";

            string netCoreVersion = NetCore.GetNetCoreVersion();
            if (string.Compare(netCoreVersion, "3") < 0)
            {
                expected = netCoreApp3expected;
            }

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(
                    expected, Program.Main);
        }
    }
}