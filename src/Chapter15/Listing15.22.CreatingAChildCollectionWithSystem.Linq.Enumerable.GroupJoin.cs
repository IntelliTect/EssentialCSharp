namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter15.Listing15_22;

using AddisonWesley.Michaelis.EssentialCSharp.Chapter15.Listing15;
#region INCLUDE
using System;
using System.Collections.Generic;
using System.Linq;
#region EXCLUDE

public class Program
{
    public static void Main()
    {
        #endregion EXCLUDE
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

        foreach (
            (_, string name, IEnumerable<Employee> employeeCollection) in items)
        {
            Console.WriteLine(name);
            foreach (Employee employee in employeeCollection)
            {
                Console.WriteLine("\t" + employee);
            }
        }
        //...
        #endregion INCLUDE
    }
}
