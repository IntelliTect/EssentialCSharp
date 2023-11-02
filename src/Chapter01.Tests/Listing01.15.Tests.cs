
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter01.Listing01_15.Tests;

[TestClass]
public class Listing01_13_Tests
{
    [TestMethod]
    public void Main_ItWouldTakeAMiracle_OutputWrittenToConsole()
    {
        const string expected =
@"It would take a miracle.";

        IntelliTect.TestTools.Console.ConsoleAssert.Expect(
            expected, StormingTheCastle.Main);
    }
}
