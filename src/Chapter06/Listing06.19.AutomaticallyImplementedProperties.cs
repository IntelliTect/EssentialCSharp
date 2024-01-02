// ����Ϊ�յ��ֶ�δ��ʼ������������Ϊ�ɿա�
#pragma warning disable CS8618

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter06.Listing06_19;

#region INCLUDE
public class Program
{
    public static void Main()
    {
        Employee employee1 =
            new();
        Employee employee2 =
            new();

        // ����FirstName���Ե�ȡֵ����(setter)
        employee1.FirstName = "Inigo";

        // ����FirstName���Եĸ�ֵ����(getter)
        System.Console.WriteLine(employee1.FirstName);

        // ���Զ�ʵ�ֵ����Ը�ֵ
        employee2.Title = "���Է�����";
        employee1.Manager = employee2;

        // ��ӡemployee1�ľ����Title
        System.Console.WriteLine(employee1.Manager.Title);
    }
}

public class Employee
{
    // FirstName����
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

    // LastName����
    public string LastName
    {
        get => _LastName;
        set => _LastName = value;
    }
    private string _LastName;

    #region HIGHLIGHT
    // Title����
    public string? Title { get; set; }
    #endregion HIGHLIGHT

    #region HIGHLIGHT
    // Manager����
    public Employee? Manager { get; set; }
    #endregion HIGHLIGHT

    #region HIGHLIGHT
    public string? Salary { get; set; } = "����";
    #endregion HIGHLIGHT
    // ...
}
#endregion INCLUDE
