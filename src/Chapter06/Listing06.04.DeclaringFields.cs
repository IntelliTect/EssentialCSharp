// 不可为空的字段未初始化。考虑声明为可空。
#pragma warning disable CS8618

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter06.Listing06_04;

#region INCLUDE
public class Employee
{
    public string FirstName; // 名字
    public string LastName;  // 姓氏
    public string? Salary;   // 工资
}
#endregion INCLUDE
