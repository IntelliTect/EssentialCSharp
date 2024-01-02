// 不可为空的字段未初始化。考虑声明为可空。
#pragma warning disable CS8618 // Pending a constructors

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter06.Listing06_23;

#region INCLUDE
public class Program
{
    public static void Main()
    {
        Employee employee1 = new();
        employee1.Initialize(42);
#if COMPILEERROR // EXCLUDE
        #region HIGHLIGHT
        // 错误：无法为属性或索引器'Employee.Id'赋值；它是只读的        
        employee1.Id = "490";
        #endregion HIGHLIGHT
#endif // COMPILEERROR // EXCLUDE
    }
}

public class Employee
{
    public void Initialize(int id)
    {
        #region HIGHLIGHT
        // 设置Id属性
        Id = id.ToString();
        #endregion HIGHLIGHT
    }

    // ...
    // Id属性声明
    public string Id
    {
        get => _Id;
        #region HIGHLIGHT
        private set => _Id = value;
        #endregion HIGHLIGHT
    }
    private string _Id;
}
#endregion INCLUDE
