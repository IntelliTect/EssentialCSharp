namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter05.Listing05_17
{
    using System;
    using System.IO;

    public class Program
    {
        public static void Main()
        {
            Employee employee = new Employee();

            // Call the FirstName property's setter.
            employee.FirstName = "Inigo";

            // Call the FirstName property's getter.
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
            get
            {
                return _LastName;
            }
            set
            {
                _LastName = value;
            }
        }
        private string _LastName;
    }
}
