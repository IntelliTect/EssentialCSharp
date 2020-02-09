
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
            set => _Name = AssertIsNotNullOrWhiteSpace(value);
        }
        private string? _Name;

        string AssertIsNotNullOrWhiteSpace(string? value) =>
             string.IsNullOrWhiteSpace(value ?? throw new ArgumentNullException(nameof(value))) ?
             throw new ArgumentException("null, or whitespace is invalide.", nameof(value)) : value;

bool TryGetDigitAsText(int number, [NotNullWhen(false)]out string? text) =>
    (text = number switch 
    {
        1 => "one",
        2 => "two",
        // ...
        9 => "nine",
        _ => null
    }) is string;

        void ReplaceIfNull([NotNullIfNotNull("text")]ref string? text) =>
            text ??= "";

        //public string LastName
        //{
        //    get => _LastName!;
        //    set => _LastName = value ?? throw new ArgumentNullException(nameof(value));
        //}
        //private string? _LastName;

        ////public string Name 
        ////{
        ////    get => ConcactName(Name, LastName);
        ////    set => ParseName(value);
        ////}

        //private void ParseName(string name)
        //{
        //    // Split the assigned value into 
        //    // first and last names
        //    string[] names = name.Split(new char[] { ' ' });
        //    if (names.Length == 2)
        //    {
        //        Name = names[0];
        //        LastName = names[1];
        //    }
        //    else
        //    {
        //        // Throw an exception if the full 
        //        // name was not assigned
        //        throw new System.ArgumentException(
        //            $"Assigned value '{ name }' is invalid",
        //            "value");
        //    }
        //}

        //static private string ConcactName(
        //    string firstName, string lastName) => $"{ firstName } { lastName }";

        //[DisallowNull][NotNull]
        //public string? Id { get; set; }
        //// ...

        //public const string EmployeeDataFile = "employees.txt";
        //private const int IdIndex = 0;
        //private const int FirstNameIndex = 1;
        //private const int LastNameIndex = 2;
        //public Employee(string id, string firstName, string lastName)
        //{
        //    Id = id;

        //    // Look up employee data using id
        //    Name = firstName;
        //    LastName = lastName;
        //    // ...
        //}
        //public static bool TryGetEmployee(string id, [NotNullWhen(true)] out Employee? employee)
        //{
        //    if (File.Exists(EmployeeDataFile))
        //    {
        //        foreach (string line in File.ReadLines(EmployeeDataFile))
        //        {
        //            if (line.StartsWith(id))
        //            {
        //                string[] employeeData = line.Split(",");
        //                employee = new Employee(employeeData[IdIndex], employeeData[FirstNameIndex], employeeData[LastNameIndex]);
        //                return true;
        //            }
        //        }
        //    }
        //    employee = null;
        //    return false;
        //}
    }
}
