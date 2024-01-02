// 不可为空的字段未初始化。考虑声明为可空。
#pragma warning disable CS8618
// Disabled pending introduction to object initializers
#pragma warning disable IDE0017 

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter06.Listing06_17;

#region INCLUDE
public class Program
{
    public static void Main()
    {
        Employee employee = new();

        // 调用FirstName属性的setter(赋值方法)
        employee.FirstName = "Inigo";

        // 调用FirstName属性的getter(取值方法)
        System.Console.WriteLine(employee.FirstName);
    }
}

public class Employee
{
    #region HIGHLIGHT
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
    #endregion HIGHLIGHT

    // ...
}
#endregion INCLUDE
