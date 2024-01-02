using AddisonWesley.Michaelis.EssentialCSharp.Chapter06.Listing06_43;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter06.Listing06_44;

#region INCLUDE
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
        (_, string firstName, string lastName, string? salary) = employee;
        #endregion HIGHLIGHT

        System.Console.WriteLine(
            "{0} {1}: {2}",
            firstName, lastName, salary);
    }
}
#endregion INCLUDE
