namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter06.Listing06_06;

using Listing06_05;
using System;

#region INCLUDE
public class Program
{
    public static void Main()
    {
        Employee employee1 = new();
        Employee employee2;
        employee2 = new Employee();

        #region HIGHLIGHT
        employee1.FirstName = "Inigo";
        employee1.LastName = "Montoya";
        employee1.Salary = "太少了";
        IncreaseSalary(employee1);
        Console.WriteLine(
           $"{ 
            employee1.FirstName } { 
            employee1.LastName }: { 
            employee1.Salary }");
        #endregion HIGHLIGHT
        // ...
    }

    public static void IncreaseSalary(Employee employee)
    {
        #region HIGHLIGHT
        employee.Salary = "勉强过活";
        #endregion HIGHLIGHT
    }
}
#endregion INCLUDE
