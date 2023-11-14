namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter06.Listing06_27;

using Listing06_30;

#region INCLUDE
public class Program
{
    public static void Main()
    {
        Employee employee;
        #region HIGHLIGHT
        employee = new("Inigo", "Montoya");
        #endregion HIGHLIGHT
        employee.Salary = "Too Little";

        Console.WriteLine(
            "{0} {1}: {2}",
            employee.FirstName,
            employee.LastName,
            employee.Salary);
    }
    // ...
}
#endregion INCLUDE
