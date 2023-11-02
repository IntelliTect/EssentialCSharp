
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter01.Listing01_08.Tests;

[TestClass]
public class ProgramTests
{
    [TestMethod]
    public void Main_InigoHello()
    {
        const string expected = @"Hello, My name is Inigo Montoya";

        IntelliTect.TestTools.Console.ConsoleAssert.Expect(
            expected, Program.Main);
    }
}
