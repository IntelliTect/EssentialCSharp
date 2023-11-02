
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter04.Listing04_34.Tests;

[TestClass]
public class ProgramTests
{
    // Fulfills left side of AND but not right
    [TestMethod]
    public void Main_Enter25ForHourOfDay_AndConditionFails()
    {
        const string expected =
            @"";

        IntelliTect.TestTools.Console.ConsoleAssert.Expect(
            expected, () => Program.Main("25"));
    }

    // Fulfills right side of AND but not left
    [TestMethod]
    public void Main_Enter5ForHourOfDay_AndConditionFails()
    {
        const string expected =
            @"";

        IntelliTect.TestTools.Console.ConsoleAssert.Expect(
            expected, () => Program.Main("5"));
    }

    // Fulfills both sides of AND
    [TestMethod]
    public void Main_Enter22ForHourOfDay_AndConditionSatisfied()
    {
        const string expected =
            @"Hi-Ho, Hi-Ho, it's off to work we go.";

        IntelliTect.TestTools.Console.ConsoleAssert.Expect(
            expected, () => Program.Main("22"));
    }
}
