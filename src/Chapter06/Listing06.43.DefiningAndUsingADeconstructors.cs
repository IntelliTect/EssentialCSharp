namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter06.Listing06_43;

#region INCLUDE
public class Employee
{
    #region EXCLUDE
    // FirstName��LastName��Initialize()�����ڲ����á�
    #pragma warning disable CS8618
    public Employee(string firstName, string lastName)
    {
        int id;
        // ����Ա��ID...
        id = 0; // ���������Ҫ��ʼ��id
        // ...
        Initialize(id, firstName, lastName);
    }

    public Employee(int id, string firstName, string lastName)
    {
        Initialize(id, firstName, lastName);
    }

    public Employee(int id)
    {
        string firstName;
        string lastName;
        Id = id;

        // ����Ա������
        firstName = string.Empty;
        lastName = string.Empty;
        // ...

        Initialize(id, firstName, lastName);
    }
    #pragma warning disable CS8618

    private void Initialize(
        int id, string firstName, string lastName)
    {
        Id = id;
        FirstName = firstName;
        LastName = lastName;
    }
    #endregion EXCLUDE
    public void Deconstruct(
        out int id, out string firstName, 
        out string lastName, out string? salary)
    {
       (id, firstName, lastName, salary) = 
            (Id, FirstName, LastName, Salary);
    }
    #region EXCLUDE
    public int Id { get; private set; }
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
                // ������Ĳ���ȫ�������׳��쳣
                throw new System.ArgumentException(
                    $"������ֵ'{value}'��Ч��");
            }
        }
    }
    #endregion EXCLUDE
}

public class Program
{
    public static void Main()
    {
        Employee employee;
        employee = new ("Inigo", "Montoya")
        {
            // ���ö����ʼ�����﷨
            Salary = "̫����"
        };
        #region EXCLUDE
        System.Console.WriteLine(
            "{0} {1}: {2}",
            employee.FirstName,
            employee.LastName,
            employee.Salary);
        #endregion EXCLUDE

        #region HIGHLIGHT
        employee.Deconstruct(out _, out string firstName,
            out string lastName, out string? salary);
        #endregion HIGHLIGHT

        System.Console.WriteLine(
            "{0} {1}: {2}",
            firstName, lastName, salary);
    }
}
#endregion INCLUDE
