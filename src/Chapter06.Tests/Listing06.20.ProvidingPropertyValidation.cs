using System;
using AddisonWesley.Michaelis.EssentialCSharp.Chapter06.Listing06_14;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter06.Listing06_20.Tests
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Initialize_NullForFirstName_ThrowsArgumentNullException()
        {
            Employee employee = new Employee();
            employee.Initialize(null, "Montoya");
        }
        
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Initialize_NullForLastName_ThrowsArgumentNullException()
        {
            Employee employee = new Employee();
            employee.Initialize("Inigo", null);
        }
        
        [TestMethod]
        public void Initialize_FirstNameWithTrailingNewLine_FirstNameTrimmed()
        {
            Employee employee = new Employee();
            employee.Initialize("Inigo\n", "Montoya");
            
            Assert.AreEqual("Inigo", employee.FirstName);
        }
        
        [TestMethod]
        public void Initialize_LastNameWithTrailingNewLine_LastNameTrimmed()
        {
            Employee employee = new Employee();
            employee.Initialize("Inigo", "Montoya\n");
            
            Assert.AreEqual("Montoya", employee.LastName);
        }
        
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Initialize_BlankForFirstName_ThrowsArgumentException()
        {
            Employee employee = new Employee();
            employee.Initialize("", "Montoya");
        }
        
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Initialize_BlankForLastName_ThrowsArgumentException()
        {
            Employee employee = new Employee();
            employee.Initialize("Inigo", "");
        }
    }
}
