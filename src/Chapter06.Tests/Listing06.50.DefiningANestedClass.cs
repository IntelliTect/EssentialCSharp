using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter06.Listing06_50
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void Main_CreatesEmployee()
        {
            string[] arguments = {
                "new",
                "15",
                "Inigo",
                "Montoya"
            };

            const string expected =
                @"'Creating' a new Employee.";
            
            IntelliTect.TestTools.Console.ConsoleAssert.Expect(
                expected, (Action<string[]>)Program.Main, arguments);
        }
        
        [TestMethod]
        public void Main_UpdateEmployee_EmployeeUpdated()
        {
            string[] arguments = {
                "update",
                "15",
                "Inigo",
                "Montoya"
            };

            const string expected =
                @"'Updating' a new Employee.";
            
            IntelliTect.TestTools.Console.ConsoleAssert.Expect(
                expected, (Action<string[]>)Program.Main, arguments);
        }
        
        [TestMethod]
        public void Main_RemovesEmployee()
        {
            string[] arguments = {
                "update",
                "15",
                "Inigo",
                "Montoya"
            };

            const string expected =
                @"'Updating' a new Employee.";
            
            IntelliTect.TestTools.Console.ConsoleAssert.Expect(
                expected, (Action<string[]>)Program.Main, arguments);
        }
    }
}
