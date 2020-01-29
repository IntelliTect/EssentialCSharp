using System;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter15.Listing15
{
    public class Department
    {
        public long Id { get; }
        public string Name { get; }
        public Department(string name, long id)
        {
            Id = id;
            Name = name ?? throw new ArgumentNullException(nameof(name));
        }
        public override string ToString()
        {
            return Name;
        }
    }

    public class Employee
    {
        public int Id { get; }
        public string Name { get; }
        public string Title { get; }
        public int DepartmentId { get; }
        public Employee(
            string name, string title, int departmentId)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Title = title ?? throw new ArgumentNullException(nameof(title));
            DepartmentId = departmentId;
        }
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
            new Department("Corporate", 0),
            new Department("Human Resources", 1),
            new Department("Engineering", 2),
            new Department("Information Technology", 3),
            new Department("Philanthropy", 4),
            new Department("Marketing", 5),
        };

        public static readonly Employee[] Employees = new Employee[]
        {
            new Employee("Mark Michaelis", "Chief Computer Nerd", 0),
            new Employee("Michael Stokesbary", "Senior Computer Wizard", 2),
            new Employee("Brian Jones", "Enterprise Integration Guru", 2),
            new Employee("Anne Beard", "HR Director", 1),
            new Employee("Pat Dever", "Enterprise Architect", 3),
            new Employee("Kevin Bost", "Programmer Extraordinaire", 2),
            new Employee("Thomas Heavey", "Software Architect", 2),
            new Employee("Eric Edmonds", "Philanthropy Coordinator", 4)
        };
    }
}
