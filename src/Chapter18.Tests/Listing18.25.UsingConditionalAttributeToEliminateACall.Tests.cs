using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter18.Listing18_25.Tests;

[TestClass]
public class ProgramTests
{
    [TestMethod]
    public void MainTest()
    {
        const string expected = @"Begin...
MethodA() executing...
End...";

        IntelliTect.TestTools.Console.ConsoleAssert.Expect(
            expected, Program.Main);
    }
}
