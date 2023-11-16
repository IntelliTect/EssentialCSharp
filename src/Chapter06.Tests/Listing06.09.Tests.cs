namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter06.Listing06_09.Tests;

[TestClass]
public class EmployeeTests
{
    [TestMethod]
    public void Employee_SetFieldsViaMethod_GetFieldValues()
    {
        Employee employee = new();
        
        employee.SetName("Inigo", "Montoya");

        Assert.AreEqual("Inigo", employee.FirstName);
        Assert.AreEqual("Montoya", employee.LastName);
        Assert.AreEqual("Inigo Montoya", employee.GetName());
    }
}
