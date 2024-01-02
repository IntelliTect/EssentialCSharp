namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter06.Listing06_30;

#region INCLUDE
public class Program
{
    public static void Main()
    {
        Employee employee = new("Inigo", "Montoya") 
            { Title = "���Է�����", Salary = "����" };
        #region EXCLUDE
        System.Console.WriteLine(
            "{0} {1} ({2}): {3}",
            employee.FirstName,
            employee.LastName,
            employee.Title,
            employee.Salary);
        #endregion EXCLUDE
    }
}
#endregion INCLUDE

public class Employee
{
    // Employee constructor
    public Employee(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }

    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string? Salary { get; set; } = "����";
    public string? Title { get; set; }
    public Employee? Manager { get; set; }

    // Name����
    public string Name
    {
        get
        {
            return FirstName + " " + LastName;
        }
        set
        {
            // ��������ֵ���Ϊ���ֺ�����
            string[] names;
            names = value.Split(new char[] { ' ' });
            if(names.Length == 2)
            {
                FirstName = names[0];
                LastName = names[1];
            }
            else
            {
                // ���������ֵ�������������׳��쳣
                throw new System.ArgumentException(
                    $"������ֵ'{value}'��Ч��");
            }
        }
    }
}
