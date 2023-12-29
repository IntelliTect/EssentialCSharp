namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter05.Listing05_29;
#pragma warning disable CS0168 // Variable is declared but never used

#region INCLUDE
// 上一个catch子句已捕获所有异常
#pragma warning disable CS1058
#region EXCLUDE
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
        // 假设不为空
        ageText = Console.ReadLine()!;

        #endregion EXCLUDE
        try
        {
            age = int.Parse(ageText);
            Console.WriteLine(
                $"你好，{firstName}！你有{age * 12}个月大了。");
        }
        catch(FormatException exception)
        {
            Console.WriteLine(
                $"你输入的年龄'{ageText}'不是一个有效的整数。"); 
            result = 1;
        }
        catch(Exception exception)
        {
            Console.WriteLine(
                $"非预期的错误: {exception.Message}");
            result = 1;
        }
        catch
        {
            Console.WriteLine("非预期的错误!");
            result = 1;
        }
        finally
        {
            Console.WriteLine($"再见，{firstName}。");
        }
        #endregion INCLUDE
        return result;
    }
}
