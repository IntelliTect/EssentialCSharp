
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter17.Listing17_18.Tests;

[TestClass]
public class ProgramTests
{
    [TestMethod]
    public void IteratingABinaryTree()
    {
        const string expected =
            @"John Fitzgerald Kennedy
Joseph Patrick Kennedy
Patrick Joseph Kennedy
Mary Augusta Hickey
Rose Elizabeth Fitzgerald
John Francis Fitzgerald
Mary Josephine Hannon";

        IntelliTect.TestTools.Console.ConsoleAssert.Expect(expected,
            () => Program.Main());
    }
}
