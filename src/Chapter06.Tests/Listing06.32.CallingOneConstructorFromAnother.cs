using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter06.Listing06_32.Tests
{
    [TestClass]
    public class EmployeeTests
    {
        [TestMethod]
        public void CallConstructor_OtherConstructorCalled_AllPropertiesSet()
        {
            Employee employee = new Employee(15, "Inigo", "Montoya");
            
            Assert.AreEqual(15, employee.Id);
            Assert.AreEqual("Inigo", employee.FirstName);
            Assert.AreEqual("Montoya", employee.LastName);
        }
    }
}
