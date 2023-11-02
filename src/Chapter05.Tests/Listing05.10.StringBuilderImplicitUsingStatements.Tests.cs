
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter05.Listing05_10.Tests;

[TestClass]
public class ProgramTests
{
    [TestMethod]
    public void Main_InputInigoMontoya_WriteFullName()
    {
        string view = """
            Enter your first name: <<Inigo
            >>
            Enter your middle initial: <<T.
            >>
            Enter your last name: <<Montoya
            >>
            Hello Inigo T. Montoya!
            """;

        IntelliTect.TestTools.Console.ConsoleAssert.Expect(view,
            Program.Main);
    }
}
