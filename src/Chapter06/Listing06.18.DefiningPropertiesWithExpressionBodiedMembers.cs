namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter06.Listing06_18
{
    using System;
    using System.IO;

    public class Program
    {
        public static void Main()
        {
            Employee employee = new Employee();

            // Call the FirstName property's setter
            employee.FirstName = "Inigo";

            // Call the FirstName property's getter
            System.Console.WriteLine(employee.FirstName);
        }
    }

    class Employee
    {
        // FirstName property
        public string FirstName
        {
            get
            {
                return _FirstName;
            }
            set
            {
                _FirstName = value;
            }
        }
        private string _FirstName;


        // LastName property
        public string LastName
        {
            get => _LastName;
            set => _LastName = value;
        }
        private string _LastName;
    }
}
