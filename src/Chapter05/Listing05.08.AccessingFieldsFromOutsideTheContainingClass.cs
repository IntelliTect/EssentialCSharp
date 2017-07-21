﻿namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter05.Listing05_08
{
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
                $"{ employee1.GetName() }: { employee1.Salary }");

        }

        static void IncreaseSalary(Employee employee)
        {
            employee.Salary = "Enough to survive on";
        }
    }

    class Employee
    {
        public string FirstName;
        public string LastName;
        public string Salary = "Not enough";

        public string GetName()
        {
            return FirstName + " " + LastName;
        }
    }
}
