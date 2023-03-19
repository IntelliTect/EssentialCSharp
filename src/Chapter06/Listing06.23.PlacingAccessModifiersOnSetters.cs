// Non-nullable field is uninitialized. Consider declaring as nullable.
#pragma warning disable CS8618 // Pending a constructors

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter06.Listing06_23;

#region INCLUDE
public class Program
{
    public static void Main()
    {
        Employee employee1 = new();
        employee1.Initialize(42);
        #if COMPILEERROR // EXCLUDE
        #region HIGHLIGHT
        // ERROR: The property or indexer 'Employee.Id' 
        // cannot be used in this context because the set 
        // accessor is inaccessible
        employee1.Id = "490";
        #endregion HIGHLIGHT
        #endif // COMPILEERROR // EXCLUDE
    }
}

public class Employee
{
    public void Initialize(int id)
    {
        #region HIGHLIGHT
        // Set Id property
        Id = id.ToString();
        #endregion HIGHLIGHT
    }

    // ...
    // Id property declaration
    public string Id
    {
        get => _Id;
        #region HIGHLIGHT
        private set => _Id = value;
        #endregion HIGHLIGHT
    }
    private string _Id;
}
#endregion INCLUDE
