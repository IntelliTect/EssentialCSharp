using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter02.Listing02_29.Tests;

[TestClass]
public class ProgramTests
{
    [TestMethod]
    public void Main_PrintBoolConvertedToString()
    {
        const string expected = "True";

        IntelliTect.TestTools.Console.ConsoleAssert.Expect(
            expected, Program.Main);
    }
}
