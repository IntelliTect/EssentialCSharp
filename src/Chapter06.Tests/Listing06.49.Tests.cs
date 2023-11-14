namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter06.Listing06_49.Tests;

[TestClass]
public class EmployeeTests
{
    [TestMethod]
    public void Employee_NextId_GetsSetInStaticConstructor()
    {
        Assert.IsTrue((100 < Employee.NextId) && (Employee.NextId < 1000));
        int id = Employee.NextId;
        _ = new Employee();
        Assert.AreEqual(id, Employee.NextId);
    }
}
