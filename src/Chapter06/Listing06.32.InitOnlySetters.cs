// 不可为空的字段未初始化。考虑声明为可空。
#pragma warning disable CS8618 // Pending a constructors

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter06.Listing06_32;

#region INCLUDE
public class Employee
{
    public Employee(int id, string name)
    {
        Id = id;
        Name = name;
        Salary = null;
    }

    // ...

    public int Id { get; }
    public string Name { get; }

    public string? Salary
    {
        get => _Salary;
        #region HIGHLIGHT
        init => _Salary = value;
        #endregion HIGHLIGHT
    }
    private string? _Salary;
}

public class Program
{
    public static void Main()
    {
        #region HIGHLIGHT
        Employee employee = new(42, "Inigo Montoya") 
        { 
            Salary = "非常充足" 
        };
        #endregion HIGHLIGHT

#if COMPILEERROR // EXCLUDE
        #region HIGHLIGHT
        // 错误：属性或索引器'Employee.Salary'不能在初始化结束后赋值
        employee.Salary = "够了";
        #endregion HIGHLIGHT
#endif // COMPILEERROR // EXCLUDE
    }
}
#endregion INCLUDE
