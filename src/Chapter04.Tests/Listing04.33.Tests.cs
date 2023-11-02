
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter04.Listing04_33.Tests;

[TestClass]
public class ProgramTests
{
    [TestMethod]
    public void Main_Enter33ForHourOfDay_TimeInvalid()
    {
        const string expected =
            @"The time you entered is invalid.";

        IntelliTect.TestTools.Console.ConsoleAssert.Expect(
            expected, ()=>Program.Main("33"));
    }
    
    [TestMethod]
    public void Main_EnterNegative1ForHourOfDay_TimeInvalid()
    {
        const string expected =
            @"The time you entered is invalid.";

        IntelliTect.TestTools.Console.ConsoleAssert.Expect(
            expected, () => Program.Main("-1"));
    }
}
