namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter02.Listing02_09.Tests;

[TestClass]
public class ProgramTests
{
    [TestMethod]
    public void Main_WriteBooleanStatements()
    {
        string currentCultureString = 86540910.21.ToString("C");
        string expected =
$@"86540910.21
{currentCultureString}
True: {currentCultureString} == {currentCultureString}
86.540.910,21 €";

        IntelliTect.TestTools.Console.ConsoleAssert.Expect(
                expected, Program.Main);
    }
}