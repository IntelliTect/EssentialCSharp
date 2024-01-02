
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter06.Listing06_08.Tests;

[TestClass]
public class ProgramTests
{
    [TestMethod]
    public void Main_AccessingFieldsFromOutsideClass_WriteFieldValues()
    {
        const string expected =
            @"Inigo Montoya: ÃãÇ¿¹ý»î";

        IntelliTect.TestTools.Console.ConsoleAssert.Expect(
            expected, Program.Main);
    }
}
