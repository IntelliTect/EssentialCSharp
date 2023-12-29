namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter05.Listing05_28;

#region INCLUDE
using System;

public class ExceptionHandling
{
    public static int Main()
    {
        string? firstName;
        string ageText;
        int age;
        int result = 0;

        Console.Write("请输入你的名字: ");
        firstName = Console.ReadLine();

        Console.Write("请输入你的年龄: ");
        // 假设不为空        // 
        ageText = Console.ReadLine()!;

        try
        {
            age = int.Parse(ageText);
            Console.WriteLine(
                $"你好，{firstName}！你有{age * 12}个月大了。"); 
        }
        finally
        {
            Console.WriteLine($"再见，{firstName}。");
        }

        return result;
    }
}
#endregion INCLUDE
