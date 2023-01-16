namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter15.Listing15_20;

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

        IEnumerable<(long Id, string Name, Employee Employee)> items =
            departments.Join(
                employees,
                department => department.Id,
                employee => employee.DepartmentId,
                (department, employee) => (
                    department.Id, 
                    department.Name, 
                    Employee: employee)
                );


        foreach ((long Id, string Name, Employee Employee) item in items)
        {
            Console.WriteLine(item.Name);
            Console.WriteLine("\t" + item.Employee);
        }
        //...
        #endregion INCLUDE
    }
}
