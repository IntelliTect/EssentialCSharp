// Non-nullable field is uninitialized. Consider declaring as nullable.
#pragma warning disable CS8618
// Disabled pending introduction to object initializers
#pragma warning disable IDE0017 

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter06.Listing06_18;

public class Program
{
    public static void Main()
    {
        Employee employee = new();

        // Call the FirstName property's setter
        employee.FirstName = "Inigo";

        // Call the FirstName property's getter
        System.Console.WriteLine(employee.FirstName);
    }
}

#region INCLUDE
public class Employee
{
    // FirstName property
    public string FirstName
    {
        get
        {
            return _FirstName;
        }
        set
        {
            _FirstName = value;
        }
    }
    #region HIGHLIGHT
    private string _FirstName;
    // LastName property
    public string LastName
    {
        get => _LastName;
        set => _LastName = value;
    }
    private string _LastName;
    #endregion HIGHLIGHT
    // ...
}
#endregion INCLUDE
