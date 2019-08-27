using System;
using System.IO;
using AddisonWesley.Michaelis.EssentialCSharp.Chapter06.Listing06_12;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter06.Listing06_13.Tests
{
    [TestClass]
    public class DataStorageTests
    {
        [TestMethod]
        public void Store_StoreInigoMontoya_WriteToFileAndRetrieve()
        {
            Employee employee = new Employee();
            employee.FirstName = "Inigo";
            employee.LastName = "Montoya";
            employee.Salary = "Too Little";

            string expected = "Inigo" + Environment.NewLine + "Montoya" + Environment.NewLine +
                              "Too Little" + Environment.NewLine;

            DataStorage.Store(employee);

            string fileName = employee.FirstName + employee.LastName + ".dat";

            var contents = File.ReadAllText(fileName);
            
            Assert.AreEqual(expected, contents);
            
            //Cleanup file
            File.Delete(employee.FirstName + employee.LastName + ".dat");
        }
    }
}
