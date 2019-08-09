using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter06.Listing06_16.Tests
{
    [TestClass]
    public class EmployeeTests
    {
        [TestMethod]
        public void SetFirstName_Inigo_FirstNameSetToInigo()
        {
            Employee employee = new Employee();
            employee.SetFirstName("Inigo");
            
            Assert.AreEqual("Inigo", employee.GetFirstName());
        }

        [TestMethod]
        public void SetFirstName_Null_FirstNameRemainsNull()
        {
            Employee employee = new Employee();
            employee.SetFirstName(null);
            
            Assert.AreEqual(null, employee.GetFirstName());
        }

        [TestMethod]
        public void SetFirstName_Blank_FirstNameRemainsNull()
        {
            Employee employee = new Employee();
            employee.SetFirstName("");
            
            Assert.AreEqual(null, employee.GetFirstName());
        }
        
        [TestMethod]
        public void SetLastName_Montoya_LastNameSetToInigo()
        {
            Employee employee = new Employee();
            employee.SetLastName("Montoya");
            
            Assert.AreEqual("Montoya", employee.GetLastName());
        }

        [TestMethod]
        public void SetLastName_Null_LastNameRemainsNull()
        {
            Employee employee = new Employee();
            employee.SetLastName(null);
            
            Assert.AreEqual(null, employee.GetLastName());
        }

        [TestMethod]
        public void SetLastName_Blank_LastNameRemainsNull()
        {
            Employee employee = new Employee();
            employee.SetLastName("");
            
            Assert.AreEqual(null, employee.GetLastName());
        }
    }
}
