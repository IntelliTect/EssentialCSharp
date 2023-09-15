// Non-nullable field is uninitialized. Consider declaring as nullable.
#pragma warning disable CS8618 // Pending a constructors

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter06.Listing06_32;

#region INCLUDE
public class Employee
{
    public Employee(int id, string name)
    {
        Id = id;
        Name = name;
        Salary = null;
    }

    // ...

    public int Id { get; }
    public string Name { get; }

    public string? Salary
    {
        get => _Salary;
        #region HIGHLIGHT
        init => _Salary = value;
        #endregion HIGHLIGHT
    }
    private string? _Salary;
}

public class Program
{
    public static void Main()
    {
        #region HIGHLIGHT
        Employee employee = new(42, "Inigo Montoya") 
        { 
            Salary = "Sufficient" 
        };
        #endregion HIGHLIGHT

        #if COMPILEERROR // EXCLUDE
        #region HIGHLIGHT
        // ERROR:  Property or indexer 'Employee.Salary' 
        // cannot be assigned after initialization completes.
        employee.Salary = "Enough";
        #endregion HIGHLIGHT
        #endif // COMPILEERROR // EXCLUDE
    }
}
#endregion INCLUDE
