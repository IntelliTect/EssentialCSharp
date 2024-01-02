namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter06.Listing06_05;

#region INCLUDE
// 暂时禁用“非可空字段未初始化”警告，因为代码尚未完成
#pragma warning disable CS8618
public class Employee
{
    public string FirstName;
    public string LastName;
    #region HIGHLIGHT
    public string? Salary = "不够";
    #endregion HIGHLIGHT
}
#endregion INCLUDE
