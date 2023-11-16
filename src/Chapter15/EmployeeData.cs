namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter15.Listing15;

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
        new("Corporate", 0),
        new("Human Resources", 1),
        new("Engineering", 2),
        new("Information Technology", 3),
        new("Philanthropy", 4),
        new("Marketing", 5),
    };

    public static readonly Employee[] Employees = new Employee[]
    {
        new("Mark Michaelis", "Chief Computer Nerd", 0),
        new("Michael Stokesbary", "Senior Computer Wizard", 2),
        new("Brian Jones", "Enterprise Integration Guru", 2),
        new("Anne Beard", "HR Director", 1),
        new("Pat Dever", "Enterprise Architect", 3),
        new("Kevin Bost", "Programmer Extraordinaire", 2),
        new("Thomas Heavey", "Software Architect", 2),
        new("Eric Edmonds", "Philanthropy Coordinator", 4)
    };
}
