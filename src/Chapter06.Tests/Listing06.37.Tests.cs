namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter06.Listing06_37.Tests;

[TestClass]
public class EmployeeTests
{
    [TestMethod]
    public void Employee_SetNameAsNull_ThrowsArgumentNullException()
    {
        Employee employee;
        Assert.ThrowsException<ArgumentNullException>(() => employee = new(null!));
    }

    [TestMethod]
    public void Employee_SetNameCorrectly()
    {
        Employee employee;
        employee = new("Inigo Montoya");
        Assert.AreEqual("Inigo Montoya", employee.Name);
    }
}
