namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter06.Listing06_47;

#region INCLUDE
using System;

public class Program
{
    public static void Main()
    {
        #region HIGHLIGHT
        Employee.NextId = 1000000;
        #endregion HIGHLIGHT

        Employee employee1 = new(
            "Inigo", "Montoya");
        Employee employee2 = new(
            "Princess", "Buttercup");

        Console.WriteLine(
            "{0} {1} ({2})",
            employee1.FirstName,
            employee1.LastName,
            employee1.Id);
        Console.WriteLine(
            "{0} {1} ({2})",
            employee2.FirstName,
            employee2.LastName,
            employee2.Id);

        #region HIGHLIGHT
        Console.WriteLine(
            $"NextId = {Employee.NextId}");
        #endregion HIGHLIGHT
    }
    // ...
}
#endregion INCLUDE
public class Employee
{
    public Employee(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
        Id = NextId;
        NextId++;
    }

    // 本章稍后会把字段包装成属性
    #pragma warning disable CA2211 // 非常量字段就当不可见
    public static int NextId = 42;
    #pragma warning disable CA2211

    public int Id { get; private set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string? Salary { get; set; } = "不够";
}
