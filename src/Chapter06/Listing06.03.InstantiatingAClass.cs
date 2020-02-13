// Justificaiton: only partial implementation provided for elucidation.
#pragma warning disable IDE0060 // Remove unused parameter

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter06.Listing06_03
{
    using Listing06_01;

    class Program
    {
        static void Main()
        {
            Employee employee1 = new Employee();
            Employee employee2;
            employee2 = new Employee();

            IncreaseSalary(employee1);
            IncreaseSalary(employee2);
        }

        static void IncreaseSalary(Employee employee)
        {
            // ...
        }
    }
}
