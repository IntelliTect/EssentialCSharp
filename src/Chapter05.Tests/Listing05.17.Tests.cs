using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter05.Listing05_17.Tests;

[TestClass]
public class ProgramTests
{
    [TestMethod]
    public void Main_WriteSwappedVariables()
    {
        string view = @"first = ""goodbye"", second = ""hello""";

        IntelliTect.TestTools.Console.ConsoleAssert.Expect(view,
        () =>
        {
            Program.Main();
        });
    }
}
