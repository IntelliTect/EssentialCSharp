
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter06.Listing06_33B
{
    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.IO;

    public class Program
    {
        public static void Main()
        {
            Employee employee = new Employee("Inigo Montoya");

            System.Console.WriteLine(employee.Name);

            // ...
        }
    }

    class Employee
    {
        public Employee(string name)
        {
            Name = name;
        }

        public string Name
        {
            get => _Name!;
            set => _Name = value ?? throw new ArgumentNullException(nameof(value));
        }
        private string? _Name;
    }
}
