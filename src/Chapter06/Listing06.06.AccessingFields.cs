namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter06.Listing06_06
{
    using Listing06_05;
    using System;

    public class Program
    {
        public static void Main()
        {
            Employee employee1 = new Employee();
            Employee employee2;
            employee2 = new Employee();

            employee1.FirstName = "Inigo";
            employee1.LastName = "Montoya";
            employee1.Salary = "Too Little";
            IncreaseSalary(employee1);
            Console.WriteLine(
                "{0} {1}: {2}",
                employee1.FirstName,
                employee1.LastName,
                employee1.Salary);
        }

        static void IncreaseSalary(Employee employee)
        {
            employee.Salary = "Enough to survive on";
        }
    }
}
