// 不可为空的字段未初始化。考虑声明为可空。
#pragma warning disable CS8618

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter06.Listing06_19;

#region INCLUDE
public class Program
{
    public static void Main()
    {
        Employee employee1 =
            new();
        Employee employee2 =
            new();

        // 调用FirstName属性的取值方法(setter)
        employee1.FirstName = "Inigo";

        // 调用FirstName属性的赋值方法(getter)
        System.Console.WriteLine(employee1.FirstName);

        // 向自动实现的属性赋值
        employee2.Title = "电脑发烧友";
        employee1.Manager = employee2;

        // 打印employee1的经理的Title
        System.Console.WriteLine(employee1.Manager.Title);
    }
}

public class Employee
{
    // FirstName属性
    public string FirstName
    {
        get
        {
            return _FirstName;
        }
        set
        {
            _FirstName = value;
        }
    }
    private string _FirstName;

    // LastName属性
    public string LastName
    {
        get => _LastName;
        set => _LastName = value;
    }
    private string _LastName;

    #region HIGHLIGHT
    // Title属性
    public string? Title { get; set; }
    #endregion HIGHLIGHT

    #region HIGHLIGHT
    // Manager属性
    public Employee? Manager { get; set; }
    #endregion HIGHLIGHT

    #region HIGHLIGHT
    public string? Salary { get; set; } = "不够";
    #endregion HIGHLIGHT
    // ...
}
#endregion INCLUDE
