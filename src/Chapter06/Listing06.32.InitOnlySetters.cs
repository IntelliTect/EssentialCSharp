// ����Ϊ�յ��ֶ�δ��ʼ������������Ϊ�ɿա�
#pragma warning disable CS8618 // Pending a constructors

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter06.Listing06_32;

#region INCLUDE
public class Employee
{
    public Employee(int id, string name)
    {
        Id = id;
        Name = name;
        Salary = null;
    }

    // ...

    public int Id { get; }
    public string Name { get; }

    public string? Salary
    {
        get => _Salary;
        #region HIGHLIGHT
        init => _Salary = value;
        #endregion HIGHLIGHT
    }
    private string? _Salary;
}

public class Program
{
    public static void Main()
    {
        #region HIGHLIGHT
        Employee employee = new(42, "Inigo Montoya") 
        { 
            Salary = "�ǳ�����" 
        };
        #endregion HIGHLIGHT

#if COMPILEERROR // EXCLUDE
        #region HIGHLIGHT
        // �������Ի�������'Employee.Salary'�����ڳ�ʼ��������ֵ
        employee.Salary = "����";
        #endregion HIGHLIGHT
#endif // COMPILEERROR // EXCLUDE
    }
}
#endregion INCLUDE
