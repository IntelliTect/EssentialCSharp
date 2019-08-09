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
            
            DataStorage.Store(employee);
        }
    }
}
