namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter05.Listing05_27;

#region INCLUDE
public class ExceptionHandling
{
    public static int Main(string[] args)
    {
        string? firstName;
        string ageText;
        int age;
        int result = 0;

        Console.WriteLine("嘿，你！");

        Console.Write("请输入你的名字: ");
        firstName = Console.ReadLine();        
        Console.Write("请输入你的年龄: ");
        // 假设不为空
        ageText = Console.ReadLine()!;

        try
        {
            age = int.Parse(ageText);
            Console.WriteLine(
                $"你好，{firstName}！你有{age * 12}个月大了。");
        }
        catch(FormatException)
        {
            Console.WriteLine(
                $"你输入的年龄'{ ageText }'不是一个有效的整数。"); 
            result = 1;
        }
        catch(Exception exception)
        {
            Console.WriteLine(
                $"非预期的错误: { exception.Message }");
            result = 1;
        }
        finally
        {
            Console.WriteLine($"再见，{ firstName }。");
        }

        return result;
    }
}
#endregion INCLUDE
