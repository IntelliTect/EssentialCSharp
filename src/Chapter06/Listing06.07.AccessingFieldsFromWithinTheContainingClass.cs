// 不可为空的字段未初始化。考虑声明为可空。
#pragma warning disable CS8618

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter06.Listing06_07;

#region INCLUDE
public class Employee
{
    public string FirstName;
    public string LastName;
    public string? Salary;

    #region HIGHLIGHT
    public string GetName()
    {
        return $"{ FirstName } { LastName }";
    }
    #endregion HIGHLIGHT
}
#endregion INCLUDE
