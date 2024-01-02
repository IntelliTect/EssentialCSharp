// 不可为空的字段未初始化。考虑声明为可空。
#pragma warning disable CS8618

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter06.Listing06_11;

using System;

#region INCLUDE
public class Employee
{
    #region EXCLUDE
    public string FirstName;
    public string LastName;
    public string? Salary = "不够";
    #endregion EXCLUDE

    public string GetName()
    {
        return $"{ FirstName } { LastName }";
    }

    public void SetName(string newFirstName, string newLastName)
    {
        this.FirstName = newFirstName;
        this.LastName = newLastName;
        #region HIGHLIGHT
        Console.WriteLine(
            $"姓名更改为'{ this.GetName() }'");
        #endregion HIGHLIGHT
    }
}

public class Program
{
    public static void Main()
    {
        Employee employee = new();

        employee.SetName("Inigo", "Montoya");
        // ...
    }
    // ...
}
#endregion INCLUDE
