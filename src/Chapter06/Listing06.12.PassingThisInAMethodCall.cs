// 不可为空的字段未初始化。考虑声明为可空。
#pragma warning disable CS8618

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter06.Listing06_12;

#region INCLUDE
public class Employee
{
    public string FirstName;
    public string LastName;
    public string? Salary;

    public void Save()
    {
        #region HIGHLIGHT
        DataStorage.Store(this);
        #endregion HIGHLIGHT
    }
}

public class DataStorage
{
    // 将Employee对象写入一个以员工姓名命名的文件
    public static void Store(Employee employee)
    {
        #region EXCLUDE
        Console.WriteLine(
            $@"将员工({
                employee.FirstName} {employee.LastName
                })的信息写入文件。");
        #endregion EXCLUDE
    }
}
#endregion INCLUDE
