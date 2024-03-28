
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter05.Listing05_20.Tests;

[TestClass]
public class ProgramTests
{
    [TestMethod]
    public void Main_InputInigoMontoya_WriteFullName()
    {
        string expected = @"image\[*\]=Red
image\[*\]=Yellow";

        IntelliTect.TestTools.Console.ConsoleAssert.ExpectLike(expected, 
            () => Program.Main());
    }
}
