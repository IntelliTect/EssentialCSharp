namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter06.Listing06_19
{
    using System;
    using System.IO;

    public class Program
    {
        public static void Main()
        {
            Employee employee1 =
                new Employee();
            Employee employee2 =
                new Employee();

            // Call the FirstName property's setter
            employee1.FirstName = "Inigo";

            // Call the FirstName property's getter
            System.Console.WriteLine(employee1.FirstName);

            // Assign an auto-implemented property
            employee2.Title = "Computer Nerd";
            employee1.Manager = employee2;

            // Print employee1's manager's title
            System.Console.WriteLine(employee1.Manager.Title);
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

        // Title property
        public string Title { get; set; }

        // Manager property
        public Employee Manager { get; set; }

        public string Salary { get; set; } = "Not Enough";

    }
}
