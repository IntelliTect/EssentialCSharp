namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter06.Listing06_07.Tests;

[TestClass]
public class EmployeeTests
{
    [TestMethod]
    public void Employee_SettingFields_GetFieldValues()
    {
        const string expected =
            "Inigo Montoya";

        Employee employee = new()
        {
            FirstName = "Inigo",
            LastName = "Montoya"
        };
        Assert.AreEqual(expected, employee.GetName());
    }
}
