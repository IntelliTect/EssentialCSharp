using IntelliTect.TestTools.Console;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter04.Listing04_55.Tests;

[TestClass]
public class GoToStatementsTests
{
    [TestMethod]
    public void Main_out_NoOutput()
    {
        string expected = "";
        ConsoleAssert.Expect(expected, () => GoToStatements.Main(["/out"]));
    }
    
    [TestMethod]
    public void Main_f_isFiltered()
    {
        string expected = "Filtering...";
        ConsoleAssert.Expect(expected, () => GoToStatements.Main(["/f"]));
    }

    [TestMethod]
    public void Main_f_out_isFiltered()
    {
        string expected = "Filtering...";
        ConsoleAssert.Expect(expected, () => GoToStatements.Main(["/f", "/out"]));
    }
}
