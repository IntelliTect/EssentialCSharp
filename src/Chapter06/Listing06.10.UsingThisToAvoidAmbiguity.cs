// ����Ϊ�յ��ֶ�δ��ʼ������������Ϊ�ɿա�
#pragma warning disable CS8618

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter06.Listing06_10;

#region INCLUDE
public class Employee
{
    public string FirstName;
    public string LastName;
    public string? Salary;

    public string GetName()
    {
        return $"{ FirstName } { LastName }";
    }

    // ���棺������ʹ����PascalCase��Сд���
    // Ӧ��ΪcamelCase��Сд���
    public void SetName(string FirstName, string LastName)
    {
        this.FirstName = FirstName;
        this.LastName = LastName;
    }
}
#endregion INCLUDE
