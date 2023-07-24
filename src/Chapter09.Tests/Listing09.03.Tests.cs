namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter09.Listing09_03.Tests;

[TestClass]
public class AngleProgramTests
{
    [TestMethod]
    public void Create_Angle_Success()
    {
        string expected =
            "Angle { Degrees = 90, Minutes = 0, Seconds = 0, Name =  }";
        IntelliTect.TestTools.Console.ConsoleAssert.Expect(
            expected, Program.Main);
    }

}
