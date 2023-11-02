
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter10.Listing10_03.Tests;

[TestClass]
public class ProgramTests
{
    [TestMethod]
    public void Main_CoordinateAdditionSubtraction()
    {
        const string expected =
@"51° 52' 0 E -1° -20' 0 N
48° 52' 0 E -2° -20' 0 N
51° 52' 0 E -1° -20' 0 N";

        IntelliTect.TestTools.Console.ConsoleAssert.Expect(
            expected, Program.Main);
    }
}
