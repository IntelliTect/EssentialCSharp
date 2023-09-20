// Non-nullable field is uninitialized. Consider declaring as nullable.
#pragma warning disable CS8618
// Disabled pending introduction to object initializers
#pragma warning disable IDE0017 

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter06.Listing06_17;

#region INCLUDE
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

public class Employee
{
    #region HIGHLIGHT
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
    private string _FirstName;
    #endregion HIGHLIGHT

    // ...
}
#endregion INCLUDE
