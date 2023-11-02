
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter18.Listing18_24.Tests;

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
