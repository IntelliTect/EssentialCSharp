// Justification: Invalid code commented out resulting in partial implementation
#pragma warning disable IDE0059 // 不需要赋值


namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter07.Listing07_06;

#region INCLUDE
public class PdaItem
{
    #region EXCLUDE
    // Justification: Disabled pending constructor
    #pragma warning disable CS8618 // 不可为空的字段未初始化。考虑声明为可空。
    #endregion EXCLUDE
    private string _Name;

    public string Name
    {
        get { return _Name; }
        set { _Name = value; }
    }
    #region EXCLUDE
    #pragma warning restore CS8618 // 不可为空的字段未初始化。考虑声明为可空。
    #endregion EXCLUDE
}

public class Contact : PdaItem
{
    // ...
}

public class Program
{
    public static void Main()
    {
        Contact contact = new();
        #region HIGHLIGHT
#if COMPILEERROR // EXCLUDE
        // 错误:  'PdaItem._Name'不可访问，因为它
        // 具有一定的保护级别
        contact._Name = "Inigo Montoya";
#endif // COMPILEERROR // EXCLUDE
        #endregion HIGHLIGHT
    }
}
#endregion INCLUDE
