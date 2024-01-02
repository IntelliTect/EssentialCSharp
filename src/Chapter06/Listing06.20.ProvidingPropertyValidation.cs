// 不可为空的字段未初始化。考虑声明为可空。
#pragma warning disable CS8618


namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter06.Listing06_20;

#region INCLUDE
public class Employee
{
    // ...
    public void Initialize(
        string newFirstName, string newLastName)
    {
        // 使用Employee类的属性
        FirstName = newFirstName;
        LastName = newLastName;
    }

    // LastName属性
    public string LastName
    {
        get => _LastName;
        set
        {
            // #region EXCLUDE
#if !NET7_0_OR_GREATER
            // 验证对LastName的赋值
            value = value?.Trim() ?? throw new ArgumentNullException(nameof(value));
            if(value.Length == 0)
            {
                // 报告错误
                throw new ArgumentException(
                    "LastName不能为空串，也不能由空白字符构成。", nameof(value));
            }
#else
            // #endregion EXCLUDE
            #region HIGHLIGHT
            // 验证对LastName的赋值
            
            ArgumentException.ThrowIfNullOrEmpty(value = value?.Trim()!);
            #endregion HIGHLIGHT
            // #region EXCLUDE
            #endif // NET7_0_OR_GREATER
            // #endregion EXCLUDE
            _LastName = value;
        }
    }
    private string _LastName;
#region EXCLUDE
    // FirstName属性
    public string FirstName
    {
        get
        {
            return _FirstName;
        }
        set
        {
            #if !NET7_0_OR_GREATER
            // 验证对FirstName的赋值
            value = value?.Trim() ?? throw new ArgumentNullException(nameof(value));
            if (value.Length == 0)
            {
                // 报告错误
                throw new ArgumentException(
                    "LastName不能为空串或者只由空白字符构成。", nameof(value));
            }
            #else // NET7_0_OR_GREATER
            // 验证对LastName的赋值
            ArgumentException.ThrowIfNullOrEmpty(value = value?.Trim()!);
            #endif // NET7_0_OR_GREATER
            _FirstName = value;
        }
    }
    private string _FirstName;
#endregion EXCLUDE
}
#endregion INCLUDE
