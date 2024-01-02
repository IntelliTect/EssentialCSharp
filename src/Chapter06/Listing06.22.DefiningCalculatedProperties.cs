// 不可为空的字段未初始化。考虑声明为可空。
#pragma warning disable CS8618 // Pending a constructors
// Disabled pending introduction to object initializers
#pragma warning disable IDE0017 

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter06.Listing06_22;

#region INCLUDE
public class Program
{
    public static void Main()
    {
        Employee employee1 = new();

        #region HIGHLIGHT
        employee1.Name = "Inigo Montoya";
        System.Console.WriteLine(employee1.Name);
        #endregion HIGHLIGHT

        // ...
    }
}

public class Employee
{
    // ...

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
    // ...

    #region HIGHLIGHT
    // Name属性
    public string Name
    {
        get
        {
            return $"{ FirstName } { LastName }";
        }
        set
        {
            // #region EXCLUDE
#if !NET7_0_OR_GREATER
            value = value?.Trim() ??
                throw new ArgumentException("Value cannot be null, empty or Whitespace");
#else
            // #endregion EXCLUDE
            ArgumentException.ThrowIfNullOrEmpty(value = value?.Trim()!);
            // #region EXCLUDE
#endif // NET7_0_OR_GREATER
            // #endregion EXCLUDE
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
                // 如果没有赋全名，就抛出异常
                throw new System.ArgumentException(
                    $"所赋的值'{ value }'无效。",
                    nameof(value));
            }
        }
    }
    #endregion HIGHLIGHT

    public string Initials => $"{ FirstName[0] } { LastName[0] }";
    #region EXCLUDE
    // Title property
    public string? Title { get; set; }

    // Manager property
    public Employee? Manager { get; set; }
    #endregion EXCLUDE
}
#endregion INCLUDE
