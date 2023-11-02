
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter17.Listing17_12.Tests;

[TestClass]
public class ProgramTests
{
    [TestMethod]
    public void IteratingABinaryTree()
    {
        const string expected =
            @"John Francis Fitzgerald
Mary Josephine Hannon";

        IntelliTect.TestTools.Console.ConsoleAssert.Expect(expected,
            Program.Main);
    }
}
