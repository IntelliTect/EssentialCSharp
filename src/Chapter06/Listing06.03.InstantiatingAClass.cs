// Justification: only partial implementation provided for elucidation.
#pragma warning disable IDE0060 // Remove unused parameter

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter06.Listing06_03;

using Listing06_01;

#region INCLUDE
public class Program
{
    public static void Main()
    {
        #region HIGHLIGHT
        Employee employee1 = new Employee();
        #endregion HIGHLIGHT
        Employee employee2;
        #region HIGHLIGHT
        employee2 = new();
        #endregion HIGHLIGHT

        IncreaseSalary(employee1);
        IncreaseSalary(employee2);
    }
    #region EXCLUDE
    public static void IncreaseSalary(Employee employee)
    {
        // ...
    }
    #endregion EXCLUDE
}
#endregion INCLUDE
