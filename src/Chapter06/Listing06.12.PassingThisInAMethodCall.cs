// ����Ϊ�յ��ֶ�δ��ʼ������������Ϊ�ɿա�
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
    // ��Employee����д��һ����Ա�������������ļ�
    public static void Store(Employee employee)
    {
        #region EXCLUDE
        Console.WriteLine(
            $@"��Ա��({
                employee.FirstName} {employee.LastName
                })����Ϣд���ļ���");
        #endregion EXCLUDE
    }
}
#endregion INCLUDE
