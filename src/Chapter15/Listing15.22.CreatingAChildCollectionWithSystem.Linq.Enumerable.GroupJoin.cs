namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter15.Listing15_22
{
    using AddisonWesley.Michaelis.EssentialCSharp.Chapter15.Listing15;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            Department[] departments = CorporateData.Departments;
            Employee[] employees = CorporateData.Employees;

            IEnumerable<(long Id, string Name, IEnumerable<Employee> Employees)> items =
                departments.GroupJoin(
                    employees,
                    department => department.Id,
                    employee => employee.DepartmentId,
                    (department, departmentEmployees) => (
                        department.Id,
                        department.Name,
                        departmentEmployees
                    ));

            foreach ((_, string name, IEnumerable<Employee> employeeCollection) in items)
            {
                Console.WriteLine(name);
                foreach (Employee employee in employeeCollection)
                {
                    Console.WriteLine("\t" + employee);
                }
            }
        }
    }
}
