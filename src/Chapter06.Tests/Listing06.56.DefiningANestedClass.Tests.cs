
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter06.Listing06_56.Tests;

[TestClass]
public class ProgramTests
{
    [TestMethod]
    public void Main_CreatesEmployee()
    {
        string[] arguments = {
            "new",
            "15",
            "Inigo",
            "Montoya"
        };

        const string expected =
            @"'Creating' a new Employee.";
        
        IntelliTect.TestTools.Console.ConsoleAssert.Expect(
            expected, (Action<string[]>)Program.Main, arguments);
    }
    
    [TestMethod]
    public void Main_UpdateEmployee_EmployeeUpdated()
    {
        string[] arguments = {
            "update",
            "15",
            "Inigo",
            "Montoya"
        };

        const string expected =
            @"'Updating' a new Employee.";
        
        IntelliTect.TestTools.Console.ConsoleAssert.Expect(
            expected, (Action<string[]>)Program.Main, arguments);
    }
    
    [TestMethod]
    public void Main_RemovesEmployee()
    {
        string[] arguments = {
            "update",
            "15",
            "Inigo",
            "Montoya"
        };

        const string expected =
            @"'Updating' a new Employee.";
        
        IntelliTect.TestTools.Console.ConsoleAssert.Expect(
            expected, (Action<string[]>)Program.Main, arguments);
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void Main_TooManyArguments_ThrowException()
    {
        string[] arguments = {
            "update",
            "15",
            "Inigo",
            "Montoya",
            "UnexpectedArgument"
        };

        Program.Main(arguments);
    }
}
