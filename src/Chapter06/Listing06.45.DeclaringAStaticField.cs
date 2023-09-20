namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter06.Listing06_45;

#region INCLUDE
public class Employee
{
    public Employee(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
        #region HIGHLIGHT
        Id = NextId;
        NextId++;
        #endregion HIGHLIGHT
    }

    // ...

    #region HIGHLIGHT
    public static int NextId;
    #endregion HIGHLIGHT
    public int Id { get; private set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string? Salary { get; set; } = "Not Enough";

    // ...
}
#endregion INCLUDE
