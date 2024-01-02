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

    // FirstName和LastName在Id属性的setter中设置
    #pragma warning disable CS8618
    public Employee(int id)
    {
        Id = id;

        // 查找员工姓名...
        // ...

        #region HIGHLIGHT
        // 注意: 成员构造函数不能以内联方式显式调用
        // this(id, firstName, lastName);
        #endregion HIGHLIGHT
    }
    #pragma warning restore CS8618

    public int Id { get; private set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string? Salary { get; set; } = "不够";

    // ...
}
#endregion INCLUDE
