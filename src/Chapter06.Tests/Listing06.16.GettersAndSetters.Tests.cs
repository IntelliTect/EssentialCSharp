using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter06.Listing06_16.Tests
{
    [TestClass]
    public class EmployeeTests
    {
        [TestMethod]
        [DataRow("Inigo")]
        [DataRow(null)]
        [DataRow("")]
        public void SetFirstName_FirstNamePropertySet(string firstName)
        {
            Employee employee = new Employee();
            employee.SetFirstName(firstName);
            
            Assert.AreEqual(firstName == "" ? null : firstName, employee.GetFirstName());
        }
        
        [TestMethod]
        [DataRow("Montoya")]
        [DataRow(null)]
        [DataRow("")]
        public void SetLastName_LastNamePropertySet(string lastName)
        {
            Employee employee = new Employee();
            employee.SetLastName(lastName);
            
            Assert.AreEqual(lastName == "" ? null : lastName, employee.GetLastName());
        }
    }
}
