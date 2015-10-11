﻿namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter14.Listing14_23
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            Department[] departments = CorporateData.Departments;
            Employee[] employees = CorporateData.Employees;

            var items = departments.Join(
                employees,
                department => department.Id,
                employee => employee.DepartmentId,
                (department, employee) => new
                {
                    department.Id,
                    department.Name,
                    Employee = employee
                });

            foreach(var item in items)
            {
                Console.WriteLine(item.Name);
                Console.WriteLine("\t" + item.Employee);
            }

        }

        private static void Print<T>(IEnumerable<T> items)
        {
            foreach(T item in items)
            {
                Console.WriteLine(item);
            }
        }
    }

    public class Department
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public override string ToString()
        {
            return Name;
        }
    }

    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public int DepartmentId { get; set; }
        public override string ToString()
        {
            return $"{ Name } ({ Title })";
        }
    }

    public static class CorporateData
    {
        public static readonly Department[] Departments =
            new Department[]
        {
            new Department()
            {
                Name = "Corporate",
                Id = 0
            },
            new Department()
            {
                Name = "Finance",
                Id = 1
            },
            new Department()
            {
                Name = "Engineering",
                Id = 2
            },
            new Department()
            {
                Name = "Information Technology",
                Id = 3
            },
            new Department()
            {
                Name = "Philanthropy",
                Id = 4
            },
            new Department()
            {
                Name = "Marketing",
                Id = 5
            },
        };

        public static readonly Employee[] Employees = new Employee[]
        {
            new Employee()
            {
                Name = "Mark Michaelis",
                Title = "Chief Computer Nerd",
                DepartmentId = 0
            },
            new Employee()
            {
                Name = "Michael Stokesbary",
                Title = "Senior Computer Wizard",
                DepartmentId = 2
            },
            new Employee()
            {
                Name = "Brian Jones",
                Title = "Enterprise Integration Guru",
                DepartmentId = 2
            },
            new Employee()
            {
                Name = "Shane Kercheval",
                Title = "Chief Financial Officer",
                DepartmentId = 1
            },
            new Employee()
            {
                Name = "Pat Dever",
                Title = "Enterprise Architect",
                DepartmentId = 3
            },
            new Employee()
            {
                Name = "Kevin Bost",
                Title = "Programmer Extraordinaire",
                DepartmentId = 2
            },
            new Employee()
            {
                Name = "Thomas Heavey",
                Title = "Software Architect",
                DepartmentId = 2
            },
            new Employee()
            {
                Name = "Eric Edmonds",
                Title = "Philanthropy Coordinator",
                DepartmentId = 4
            }
        };
    }
}