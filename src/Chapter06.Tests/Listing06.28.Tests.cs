namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter06.Listing06_28.Tests;

[TestClass]
public class ProgramTests
{
    [TestMethod]
    public void Main_UsingAConstructor_WriteFirstNameLastNameSalary()
    {
        const string expected =
            "Inigo Montoya: Too Little";

        IntelliTect.TestTools.Console.ConsoleAssert.Expect(
            expected, Program.Main);
    }

    [TestMethod]
    public void Employee_Constructor_SetsValuesProperly()
    {
        Employee employee = new("Inigo", "Montoya");
        Assert.AreEqual("Inigo Montoya", employee.FullName);
        Assert.AreEqual("Inigo", employee.FirstName);
        Assert.AreEqual("Montoya", employee.LastName);
    }

    [TestMethod]
    public void Employee_SetInvalidFullName_ThrowsArgumentNullException()
    {
        Employee employee = new("Inigo", "Montoya");
        Assert.ThrowsException<ArgumentException>(() => employee.FullName = "FirstName");
    }

    [TestMethod]
    public void Employee_SetFullName_SetsNameCorrectly()
    {
        Employee employee = new("Blah", "Blah")
        {
            FullName = "Inigo Montoya"
        };
        Assert.AreEqual("Inigo Montoya", employee.FullName);
        Assert.AreEqual("Inigo", employee.FirstName);
        Assert.AreEqual("Montoya", employee.LastName);
    }
}
