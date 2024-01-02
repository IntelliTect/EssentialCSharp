// 不可为空的字段未初始化。考虑声明为可空。
#pragma warning disable CS8618
// Disabled pending introduction to object initializers
#pragma warning disable IDE0017 

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter06.Listing06_18;

public class Program
{
    public static void Main()
    {
        Employee employee = new();

        // 调用FirstName属性的取值方法(setter)
        employee.FirstName = "Inigo";

        // 调用FirstName属性的赋值方法(getter)
        System.Console.WriteLine(employee.FirstName);
    }
}

#region INCLUDE
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
    #region HIGHLIGHT
    private string _FirstName;
    // LastName属性
    public string LastName
    {
        get => _LastName;
        set => _LastName = value;
    }
    private string _LastName;
    #endregion HIGHLIGHT
    // ...
}
#endregion INCLUDE
