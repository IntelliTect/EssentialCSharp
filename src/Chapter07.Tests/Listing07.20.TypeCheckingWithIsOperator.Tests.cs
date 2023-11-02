
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter07.Listing07_20.Tests;

[TestClass]
public class ProgramTests
{
    [TestMethod]
    public void Main_GivenEmployeeID_PersonAndEmployee()
    {
        const string expected = """
            Id corresponds to a Person object: Inigo Montoya.
            Id (46041779-79D5-4268-BCD9-25BF61F8B4F6) is also an Employee object.
            """;

        IntelliTect.TestTools.Console.ConsoleAssert.Expect(
            expected,
            () => Program.Main("Employee46041779-79D5-4268-BCD9-25BF61F8B4F6")
        ) ;
    }

    [TestMethod]
    public void Main_GivenPerson_Person()
    {
        const string expected = "Id corresponds to a Person object: Inigo Montoya.";

        IntelliTect.TestTools.Console.ConsoleAssert.Expect(
            expected,
            () => Program.Main("Person")
        );
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentNullException))]
    public void Main_GivenNull_Null()
    {
        Program.Main(new string[] { null! });
    }

    [TestMethod]
    public void Main_GivenUnknownId_NotPersonOrEmployee()
    {
        Guid guid = Guid.NewGuid();
        string expected = "Id was unknown so null was returned.";

        IntelliTect.TestTools.Console.ConsoleAssert.Expect(
            expected,
            () => Program.Main(guid.ToString())
        );
    }
}
