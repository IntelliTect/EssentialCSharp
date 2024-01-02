// Add readonly modifier ignored pending introduction of the concept
#pragma warning disable IDE0044
#pragma warning disable 649 // _Id从未赋值

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter06.Listing06_33;

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
    {
        Id = id;
        FirstName = firstName;
        LastName = lastName;
    }

    // FirstName和LastName在Id属性的setter中设置
    #pragma warning disable CS8618
    public Employee(int id) => Id = id;
    #pragma warning restore CS8618

    private int _Id;
    public int Id
    {
        get => _Id;
        private set
        {
            // 查找员工姓名...
            // ...
        }
    }
    #endregion HIGHLIGHT
    #region EXCLUDE
    [System.Diagnostics.CodeAnalysis.NotNull]
    [System.Diagnostics.CodeAnalysis.DisallowNull]
    #endregion EXCLUDE
    public string FirstName { get; set; }
    #region EXCLUDE
    [System.Diagnostics.CodeAnalysis.DisallowNull]
    [System.Diagnostics.CodeAnalysis.NotNull]
    #endregion EXCLUDE
    public string LastName { get; set; }
    public string? Salary { get; set; } = "不够";


    // ...
}
#endregion INCLUDE
