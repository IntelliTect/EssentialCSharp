namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter06.Listing06_34;

#region INCLUDE
public class Employee
{
    public Employee(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }

    #region HIGHLIGHT
    public Employee(
        int id, string firstName, string lastName)
        : this(firstName, lastName)
    #endregion HIGHLIGHT
    {
        Id = id;
    }

    // FirstName��LastName��Id���Ե�setter������
    #pragma warning disable CS8618
    public Employee(int id)
    {
        Id = id;

        // ����Ա������...
        // ...

        #region HIGHLIGHT
        // ע��: ��Ա���캯��������������ʽ��ʽ����
        // this(id, firstName, lastName);
        #endregion HIGHLIGHT
    }
    #pragma warning restore CS8618

    public int Id { get; private set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string? Salary { get; set; } = "����";

    // ...
}
#endregion INCLUDE
