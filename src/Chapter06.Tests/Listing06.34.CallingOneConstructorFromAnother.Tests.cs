
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter06.Listing06_34.Tests;

[TestClass]
public class EmployeeTests
{
    [TestMethod]
    public void CallConstructor_OtherConstructorCalled_AllPropertiesSet()
    {
        Employee employee = new(15, "Inigo", "Montoya");
        
        Assert.AreEqual(15, employee.Id);
        Assert.AreEqual("Inigo", employee.FirstName);
        Assert.AreEqual("Montoya", employee.LastName);
    }
}
