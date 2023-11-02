
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter01.Listing01_11.Tests;

[TestClass]
public class ProgramTests
{
    [TestMethod]
    public void Main_HelloToInigo()
    {
        const string expected = @"Hello Inigo Montoya";

        IntelliTect.TestTools.Console.ConsoleAssert.Expect(
            expected, HelloWorld.Main);
    }
}
