// Non-nullable field is uninitialized. Consider declaring as nullable.
#pragma warning disable CS8618

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter06.Listing06_12;

#region INCLUDE
public class Employee
{
    public string FirstName;
    public string LastName;
    public string? Salary;

    public void Save()
    {
        #region HIGHLIGHT
        DataStorage.Store(this);
        #endregion HIGHLIGHT
    }
}

public class DataStorage
{
    // Save an employee object to a file 
    // named with the Employee name
    public static void Store(Employee employee)
    {
        #region EXCLUDE
        Console.WriteLine(
            $@"Writing employee ({
                employee.FirstName} {employee.LastName
                }) information to file.");
        #endregion EXCLUDE
    }
}
#endregion INCLUDE
