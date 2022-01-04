using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter06.Listing06_33.Tests
{
    [TestClass]
    public class EmployeeTests
    {
        [TestMethod]
        public void InitializeMethod_InitializeSetsProperties_PropertiesCorrectlySet()
        {
            Employee employee = new Employee(15, "Inigo", "Montoya");
            
            Assert.AreEqual(15, employee.Id);
            Assert.AreEqual("Inigo", employee.FirstName);
            Assert.AreEqual("Montoya", employee.LastName);
        }
    }
}
