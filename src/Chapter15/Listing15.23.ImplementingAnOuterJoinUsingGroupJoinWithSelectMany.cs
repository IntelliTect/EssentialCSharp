namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter15.Listing15_23;

using AddisonWesley.Michaelis.EssentialCSharp.Chapter15.Listing15;
#region INCLUDE
using System;
using System.Linq;
#region EXCLUDE

public class Program
{
    public static void Main()
    {
        #endregion EXCLUDE
        Department[] departments = CorporateData.Departments;
        Employee[] employees = CorporateData.Employees;

        var items = departments.GroupJoin(
            employees,
            department => department.Id,
            employee => employee.DepartmentId,
            (department, departmentEmployees) => new
            {
                department.Id,
                department.Name,
                Employees = departmentEmployees
            }).SelectMany(
                departmentRecord =>
                    departmentRecord.Employees.DefaultIfEmpty(),
                (departmentRecord, employee) => new
                {
                    departmentRecord.Id,
                    departmentRecord.Name,
                    departmentRecord.Employees
                }).Distinct();

        foreach (var item in items)
        {
            Console.WriteLine(item.Name);
            foreach (Employee employee in item.Employees)
            {
                Console.WriteLine("\t" + employee);
            }
        }
        //...
        #endregion INCLUDE
    }
}
