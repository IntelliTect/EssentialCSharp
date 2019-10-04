using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter06.Listing06_16.Tests
{
    [TestClass]
    public class EmployeeTests
    {
        [TestMethod]
        [DataRow("Inigo", "Inigo")]
        [DataRow(null, null)]
        [DataRow("", null)]
        public void SetFirstName_FirstNamePropertySet(string firstName, string expected)
        {
            Employee employee = new Employee();
            employee.SetFirstName(firstName);
            
            Assert.AreEqual(expected, employee.GetFirstName());
        }
        
        [TestMethod]
        [DataRow("Montoya", "Montoya")]
        [DataRow(null, null)]
        [DataRow("", null)]
        public void SetLastName_LastNamePropertySet(string lastName, string expected)
        {
            Employee employee = new Employee();
            employee.SetLastName(lastName);
            
            Assert.AreEqual(expected, employee.GetLastName());
        }
    }
}
