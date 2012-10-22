namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter05.Listing05_11
{
    using System;

    public class Program
    {
        public static void Main()
        {
            Employee employee = new Employee();

            employee.SetName("Inigo", "Montoya");
        }

        static void IncreaseSalary(Employee employee)
        {
            employee.Salary = "Enough to survive on";
        }
    }

    class Employee
    {
        public string FirstName;
        public string LastName;
        public string Salary = "Not enough";

        public string GetName()
        {
            return FirstName + " " + LastName;
        }

        public void SetName(string newFirstName, string newLastName)
        {
            this.FirstName = newFirstName;
            this.LastName = newLastName;
            Console.WriteLine("Name changed to '{0}'",
                this.GetName());
        }
    }
}
