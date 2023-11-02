
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter07.Listing07_32.Tests;

[TestClass]
public class ProgramTests
{

    [TestMethod]
    public void RecursivePatternMatchingTest()
    {
        IntelliTect.TestTools.Console.ConsoleAssert.Expect(
            "(5, Princess)", () => Program.Main());
    }
}
