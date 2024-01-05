// 不可为空的字段未初始化。考虑声明为可空。
#pragma warning disable CS8618 // Disabled pending constructor
        
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter07.Listing07_09;

#region INCLUDE
public class PdaItem
{
    #region HIGHLIGHT
    public virtual string Name { get; set; }
    #endregion HIGHLIGHT
    // ...
}

public class Contact : PdaItem
{
    #region HIGHLIGHT
    public override string Name
    #endregion HIGHLIGHT
    {
        get
        {
            return $"{ FirstName } { LastName }";
        }

        set
        {
            string[] names = value.Split(' ');
            // 未显示错误处理
            FirstName = names[0];
            LastName = names[1];
        }
    }

    public string FirstName { get; set; }
    public string LastName { get; set; }

    // ...
}
#endregion INCLUDE
