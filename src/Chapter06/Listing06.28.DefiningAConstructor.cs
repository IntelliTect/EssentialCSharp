namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter06.Listing06_28;

public class Program
{
    public static void Main()
    {
        Employee employee;
        employee = new("Inigo", "Montoya")
        {
            Salary = "太少了"
        };

        Console.WriteLine(
            "{0} {1}: {2}",
            employee.FirstName,
            employee.LastName,
            employee.Salary);
    }
}

#region INCLUDE
public class Employee
{
    #region HIGHLIGHT
    // Employee构造函数
    public Employee(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }
    #endregion HIGHLIGHT

    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string? Salary { get; set; } = "不够";

    #region EXCLUDE
    public string? Title { get; set; }
    public Employee? Manager { get; set; }

    // FullName属性
    public string FullName
    {
        get
        {
            return FirstName + " " + LastName;
        }
        set
        {
            // 将所赋值的值拆分为名字和姓氏
            string[] names;
            names = value.Split(new char[] { ' ' });
            if(names.Length == 2)
            {
                FirstName = names[0];
                LastName = names[1];
            }
            else
            {
                // 未赋全名就抛出异常
                throw new ArgumentException(
                    string.Format(
                    $"所赋的值'{ value }'无效。", 
                    nameof(value)));
            }
        }
    }
    #endregion EXCLUDE
}
#endregion INCLUDE
