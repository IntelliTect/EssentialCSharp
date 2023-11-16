namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter06.Listing06_46.Tests;

[TestClass]
public class EmployeeTests
{
    [TestMethod]
    public void Employee_NextId_SetsAtDeclaration()
    {
        Assert.AreEqual(42, Employee.NextId);
        _ = new Employee();
        Assert.AreEqual(42, Employee.NextId);
    }
}
