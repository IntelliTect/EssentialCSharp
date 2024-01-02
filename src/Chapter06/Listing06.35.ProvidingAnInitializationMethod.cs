namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter06.Listing06_35;

public class Program
{
    public static void Main()
    {
        System.Console.WriteLine("本例无实际输出");
    }
}

#region INCLUDE
public class Employee
{
    // FirstName和LastName在Initialize()方法内部设置
    #pragma warning disable CS8618
    public Employee(string firstName, string lastName)
    {
        int id;
        // 生成employee ID...
        #region EXCLUDE
        id = 0; // 本例需要初始化id
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

        // 查找员工数据
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
                // 如果没有赋全名，就抛出异常
                throw new System.ArgumentException(
                    $"所赋的值'{value}'无效。");
            }
        }
    }
    #endregion EXCLUDE
}
#endregion INCLUDE
