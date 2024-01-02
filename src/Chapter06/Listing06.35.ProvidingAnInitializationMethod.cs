namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter06.Listing06_35;

public class Program
{
    public static void Main()
    {
        System.Console.WriteLine("������ʵ�����");
    }
}

#region INCLUDE
public class Employee
{
    // FirstName��LastName��Initialize()�����ڲ�����
    #pragma warning disable CS8618
    public Employee(string firstName, string lastName)
    {
        int id;
        // ����employee ID...
        #region EXCLUDE
        id = 0; // ������Ҫ��ʼ��id
        #endregion EXCLUDE
        #region HIGHLIGHT
        Initialize(id, firstName, lastName);
        #endregion HIGHLIGHT
    }

    public Employee(int id, string firstName, string lastName)
    {
        #region HIGHLIGHT
        Initialize(id, firstName, lastName);
        #endregion HIGHLIGHT
    }

    public Employee(int id)
    {
        string firstName;
        string lastName;
        Id = id;

        // ����Ա������
        #region EXCLUDE
        firstName = string.Empty;
        lastName = string.Empty;
        #endregion EXCLUDE

        #region HIGHLIGHT
        Initialize(id, firstName, lastName);
        #endregion HIGHLIGHT
    }
    #pragma warning restore CS8618

    #region HIGHLIGHT
    private void Initialize(
        int id, string firstName, string lastName)
    {
        Id = id;
        FirstName = firstName;
        LastName = lastName;
    }
    #endregion HIGHLIGHT
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
                // ���û�и�ȫ�������׳��쳣
                throw new System.ArgumentException(
                    $"������ֵ'{value}'��Ч��");
            }
        }
    }
    #endregion EXCLUDE
}
#endregion INCLUDE
