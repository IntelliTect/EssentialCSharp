namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter15.Listing15_19
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

            IEnumerable<(int Id, string Name, string Title, 
                Department Department)> items =
                employees.Join(
                    departments,
                    employee => employee.DepartmentId,
                    department => department.Id,
                    (employee, department) => (
                        employee.Id,
                        employee.Name,
                        employee.Title,
                        department
                    ));


            foreach ((int Id, string Name, string Title, Department Department) item in items)
            {
                Console.WriteLine(
                    $"{ item.Name } ({ item.Title })");
                Console.WriteLine("\t" + item.Department);
            }
        }
    }
}
