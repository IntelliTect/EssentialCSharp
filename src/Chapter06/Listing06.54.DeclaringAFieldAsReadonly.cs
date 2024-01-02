namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter06.Listing06_54;

#region INCLUDE
public class Employee
{
    public Employee(int id)
    {
      _Id = id;
    }

    // ...

    #region HIGHLIGHT
    private readonly int _Id;
    #endregion HIGHLIGHT
    public int Id
    {
      get { return _Id; }
    }

#if COMPILEERROR // EXCLUDE
    // 错误：不能向只读字段赋值(除非通过构造函数或者变量初始化器)
    public void SetId(int id) =>
        _Id = id;
#endif // COMPILEERROR // EXCLUDE

    // ...
}
#endregion INCLUDE
