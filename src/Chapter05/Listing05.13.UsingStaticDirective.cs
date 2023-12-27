namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter05.Listing05_13;

#region INCLUDE
using static System.Console;

public class HeyYou
{
    public static void Main()
    {
        string? firstName;  // 用于存储名字的变量
        string? lastName;   // 用于存储姓氏的变量

        WriteLine("嘿，你！");

        Write("请输入你的名字: ");
        firstName = ReadLine() ?? string.Empty;

        Write("请输入你的姓氏: ");
        lastName = ReadLine() ?? string.Empty;

        WriteLine(
            $"你的全名是{firstName} {lastName}。");
    }
}
#endregion INCLUDE
