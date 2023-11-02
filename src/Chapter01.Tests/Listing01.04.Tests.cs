
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter01.Listing01_04.Tests;

[TestClass]
public class HelloWorldTests
{
    [TestMethod]
    public void Main_InigoHello()
    {
        const string expected =
            @"Down
Side
Up";

        IntelliTect.TestTools.Console.ConsoleAssert.Expect(
            expected, HelloWorld.Main);
    }
}
