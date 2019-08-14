using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter06.Listing06_31.Tests
{
    [TestClass]
    public class EmployeeTests
    {
        [TestMethod]
        public void EmployeeConstructor_TwoParameterConstructorSuccess()
        {
            Employee employee = new Employee("Inigo", "Montoya");
            
            Assert.AreEqual("Inigo", employee.FirstName);
            Assert.AreEqual("Montoya", employee.LastName);
        }
    }
}
