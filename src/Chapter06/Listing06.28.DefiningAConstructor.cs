namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter06.Listing06_28;

public class Program
{
    public static void Main()
    {
        Employee employee;
        employee = new("Inigo", "Montoya")
        {
            Salary = "̫����"
        };

        Console.WriteLine(
            "{0} {1}: {2}",
            employee.FirstName,
            employee.LastName,
            employee.Salary);
    }
}

#region INCLUDE
public class Employee
{
    #region HIGHLIGHT
    // Employee���캯��
    public Employee(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }
    #endregion HIGHLIGHT

    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string? Salary { get; set; } = "����";

    #region EXCLUDE
    public string? Title { get; set; }
    public Employee? Manager { get; set; }

    // FullName����
    public string FullName
    {
        get
        {
            return FirstName + " " + LastName;
        }
        set
        {
            // ������ֵ��ֵ���Ϊ���ֺ�����
            string[] names;
            names = value.Split(new char[] { ' ' });
            if(names.Length == 2)
            {
                FirstName = names[0];
                LastName = names[1];
            }
            else
            {
                // δ��ȫ�����׳��쳣
                throw new ArgumentException(
                    string.Format(
                    $"������ֵ'{ value }'��Ч��", 
                    nameof(value)));
            }
        }
    }
    #endregion EXCLUDE
}
#endregion INCLUDE
