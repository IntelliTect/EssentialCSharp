namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter06.Listing06_45.Tests;

[TestClass]
public class EmployeeTests
{
    [TestMethod]
    public void Employee_NextId_IncrementsAcrossInstances()
    {
        Assert.AreEqual(0, Employee.NextId);
        Employee employee = new("Inigo", "Montoya");
        Assert.AreEqual(1, Employee.NextId);
        Assert.AreEqual(0, employee.Id);
        employee = new("Fezzik", "Giant");
        Assert.AreEqual(2, Employee.NextId);
        Assert.AreEqual(1, employee.Id);
    }
}
