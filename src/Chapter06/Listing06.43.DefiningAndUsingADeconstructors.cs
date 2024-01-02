namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter06.Listing06_43;

#region INCLUDE
public class Employee
{
    #region EXCLUDE
    // FirstName和LastName在Initialize()方法内部设置。
    #pragma warning disable CS8618
    public Employee(string firstName, string lastName)
    {
        int id;
        // 生成员工ID...
        id = 0; // 这个例子需要初始化id
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

        // 查找员工数据
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
    public string? Salary { get; set; } = "不够";
    public string? Title { get; set; }
    public Employee? Manager { get; set; }

    // Name属性
    public string Name
    {
        get
        {
            return FirstName + " " + LastName;
        }
        set
        {
            // 将所赋的值拆分为名字和姓氏
            string[] names;
            names = value.Split(new char[] { ' ' });
            if(names.Length == 2)
            {
                FirstName = names[0];
                LastName = names[1];
            }
            else
            {
                // 如果赋的不是全名，就抛出异常
                throw new System.ArgumentException(
                    $"所赋的值'{value}'无效。");
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
            // 利用对象初始化器语法
            Salary = "太少了"
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
