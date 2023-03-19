// In a completed implementation we would use our Employee objects
#pragma warning disable CS0168 // Variable is declared but never used
#pragma warning disable IDE0060 // Remove unused parameter
#pragma warning disable IDE0051 // Remove unused private members

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter06.Listing06_02;

using Listing06_01;

#region INCLUDE
public class Program
{
    public static void Main()
    {
        #region HIGHLIGHT
        Employee employee1, employee2;
        #endregion HIGHLIGHT
        // ...
    }

    #region HIGHLIGHT
    public static void IncreaseSalary(Employee employee)
    #endregion HIGHLIGHT
    {
        // ...
    }
}
#endregion INCLUDE
