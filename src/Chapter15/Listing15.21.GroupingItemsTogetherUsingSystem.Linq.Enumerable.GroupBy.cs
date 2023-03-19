namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter15.Listing15_21;

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
        //...
        #endregion INCLUDE
    }
}
