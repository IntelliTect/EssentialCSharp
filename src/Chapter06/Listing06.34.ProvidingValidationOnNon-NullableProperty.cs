namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter06.Listing06_34
{
    using System;

    public class Program
    {
        public static void Main()
        {
            Employee employee = new Employee("Inigo Montoya");

            System.Console.WriteLine(employee.Name);

            // ...
        }
    }
    #region INCLUDE
    public class Employee
    {
        public Employee(string name)
        {
            #region HIGHLIGHT
            Name = name;
            #endregion HIGHLIGHT
        }

        public string Name
        {
            #region HIGHLIGHT
            get => _Name!;
            #endregion HIGHLIGHT
            set => _Name =
                #region HIGHLIGHT
                value ?? throw new ArgumentNullException(nameof(value));
            #endregion HIGHLIGHT
        }
        private string? _Name;
        // ...
    }
    #endregion INCLUDE
}
