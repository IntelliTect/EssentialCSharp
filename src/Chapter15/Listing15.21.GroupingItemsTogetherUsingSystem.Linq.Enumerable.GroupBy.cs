namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter15.Listing15_21
{
    using AddisonWesley.Michaelis.EssentialCSharp.Chapter15.Listing15;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            IEnumerable<Employee> employees = CorporateData.Employees;

            IEnumerable<IGrouping<int, Employee>> groupedEmployees =
                employees.GroupBy((employee) => employee.DepartmentId);

            foreach(IGrouping<int, Employee> employeeGroup in
                groupedEmployees)
            {
                Console.WriteLine();
                foreach(Employee employee in employeeGroup)
                {
                    Console.WriteLine(employee);
                }
                Console.WriteLine(
                  "\tCount: " + employeeGroup.Count());
            }

        }
    }
}
