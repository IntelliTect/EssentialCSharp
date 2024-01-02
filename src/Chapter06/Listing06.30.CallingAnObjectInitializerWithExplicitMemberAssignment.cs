namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter06.Listing06_30;

#region INCLUDE
public class Program
{
    public static void Main()
    {
        Employee employee = new("Inigo", "Montoya") 
            { Title = "电脑发烧友", Salary = "不够" };
        #region EXCLUDE
        System.Console.WriteLine(
            "{0} {1} ({2}): {3}",
            employee.FirstName,
            employee.LastName,
            employee.Title,
            employee.Salary);
        #endregion EXCLUDE
    }
}
#endregion INCLUDE

public class Employee
{
    // Employee constructor
    public Employee(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }

    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string? Salary { get; set; } = "不够";
    public string? Title { get; set; }
    public Employee? Manager { get; set; }

    // Name属性
    public string Name
    {
        get
        {
            return FirstName + " " + LastName;
        }
        set
        {
            // 将所赋的值拆分为名字和姓氏
            string[] names;
            names = value.Split(new char[] { ' ' });
            if(names.Length == 2)
            {
                FirstName = names[0];
                LastName = names[1];
            }
            else
            {
                // 如果所赋的值不是命名，就抛出异常
                throw new System.ArgumentException(
                    $"所赋的值'{value}'无效。");
            }
        }
    }
}
