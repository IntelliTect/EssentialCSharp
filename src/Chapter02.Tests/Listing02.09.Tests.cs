using System.Globalization;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter02.Listing02_09.Tests;

[TestClass]
public class ProgramTests
{
    [TestMethod]
    public void Main_WriteBooleanStatements()
    {
        var number = 86540910.21;
        string currentCultureString = number.ToString("C");
        string greekCultureString = number.ToString("C", CultureInfo.GetCultureInfo("el-GR"));
        string expected =
$@"{number}
{currentCultureString}
True: {currentCultureString} == {currentCultureString}
{greekCultureString}";

        IntelliTect.TestTools.Console.ConsoleAssert.Expect(
                expected, Program.Main);
    }
}