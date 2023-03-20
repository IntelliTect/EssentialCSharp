namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter06.Listing06_05;

#region INCLUDE
// Non-nullable field uninitialized warning disabled while code is incomplete
#pragma warning disable CS8618
public class Employee
{
    public string FirstName;
    public string LastName;
    #region HIGHLIGHT
    public string? Salary = "Not enough";
    #endregion HIGHLIGHT
}
#endregion INCLUDE
