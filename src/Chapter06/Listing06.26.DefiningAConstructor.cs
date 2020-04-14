// Disabled pending introductin to object initializers
#pragma warning disable IDE0017 

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter06.Listing06_26
{
    public class Program
    {
        public static void Main()
        {
            Employee employee;
            employee = new Employee("Inigo", "Montoya");
            employee.Salary = "Too Little";

            System.Console.WriteLine(
                "{0} {1}: {2}",
                employee.FirstName,
                employee.LastName,
                employee.Salary);
        }
    }

    class Employee
    {
        // Employee constructor
        public Employee(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string? Salary { get; set; } = "Not Enough";
        public string? Title { get; set; }
        public Employee? Manager { get; set; }

        // Name property
        public string Name
        {
            get
            {
                return FirstName + " " + LastName;
            }
            set
            {
                // Split the assigned value into 
                // first and last names
                string[] names;
                names = value.Split(new char[] { ' ' });
                if(names.Length == 2)
                {
                    FirstName = names[0];
                    LastName = names[1];
                }
                else
                {
                    // Throw an exception if the full 
                    // name was not assigned
                    throw new System.ArgumentException(
                        string.Format(
                        $"Assigned value '{ value }' is invalid", 
                        nameof(value)));
                }
            }
        }
    }
}
