namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter15.Listing15_18
{
    using AddisonWesley.Michaelis.EssentialCSharp.Chapter15.Listing15;
    using System;
    using System.Collections.Generic;

    public class Program
    {
        public static void Main()
        {
            IEnumerable<Department> departments =
                CorporateData.Departments;
            Print(departments);

            Console.WriteLine();

            IEnumerable<Employee> employees =
                CorporateData.Employees;
            Print(employees);
        }

        private static void Print<T>(IEnumerable<T> items)
        {
            foreach(T item in items)
            {
                Console.WriteLine(item);
            }
        }
    }
}
