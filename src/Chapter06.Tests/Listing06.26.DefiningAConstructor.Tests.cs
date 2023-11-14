
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter06.Listing06_26.Tests;

[TestClass]
public class ProgramTests
{
#if NET8_0_OR_GREATER
    [TestMethod]
    public void Main_UsingAConstructor_WriteFirstNameLastNameSalary()
    {
        const string expected =
            @"Inigo Montoya: Too Little";

        IntelliTect.TestTools.Console.ConsoleAssert.Expect(
            expected, Program.Main);
    }

    [TestMethod]
    public void Employee_NotFullNamePassed_ThrowArgumentException()
    {
        Employee employee = new("Inigo", "Montoya");
        Assert.ThrowsException<ArgumentException>(
                       () => employee.FullName = "FirstName");
    }

    [TestMethod]
    public void Employee_FullNamePassed_SetsProperly()
    {
        Employee employee = new("Inigo", "Montoya");
        employee.FullName = "Inigo Montoya";
        Assert.AreEqual("Inigo Montoya", employee.FullName);
        Assert.AreEqual("Inigo", employee.FirstName);
        Assert.AreEqual("Montoya", employee.LastName);
    }
#endif // NET8_0_OR_GREATER
}
