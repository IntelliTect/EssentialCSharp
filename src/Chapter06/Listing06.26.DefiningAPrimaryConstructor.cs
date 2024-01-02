namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter06.Listing06_26;

#if NET8_0_OR_GREATER
public class Program
{
    public static void Main()
    {
        Employee employee = new("Inigo", "Montoya")
        {
            Salary = "太少了"
        };

        Console.WriteLine(
            $"{employee.FirstName} {employee.LastName}: {employee.Salary}");
    }
}

#region INCLUDE
#region HIGHLIGHT
// Employee构造函数
public class Employee(string firstName, string lastName)
{
    public string FirstName { get; set; } = firstName;
    public string LastName { get; set; } = lastName;
#endregion HIGHLIGHT
    public string? Salary { get; set; } = "不够";

    #region EXCLUDE
    public string? Title { get; set; }
    public Employee? Manager { get; set; }

    // Name属性
    public string FullName
    {
        get
        {
            return FirstName + " " + LastName;
        }
        set
        {
            // 将所赋的值拆分为名字和姓氏
            string[] names = value.Split(' ');
            if(names.Length == 2)
            {
                FirstName = names[0];
                LastName = names[1];
            }
            else
            {
                // 如果未赋命名，那么抛出一个异常
                throw new ArgumentException(
                   $"所赋的值'{ value }'无效。", 
                    nameof(value));
            }
        }
    }
    #endregion EXCLUDE
}
#endregion INCLUDE
#endif // NET8_0_OR_GREATER