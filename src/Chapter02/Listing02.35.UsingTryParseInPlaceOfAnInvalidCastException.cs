// Justification: Inline variable declaration not explained yet.
#pragma warning disable IDE0018 // Inline variable declaration
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter02.Listing02_35;

public class Program
{
    public static void Main()
    {
        #region INCLUDE
        double number; // 老版本C#要求变量先声明才能作为out参数使用
        string input;

        Console.Write("输入一个数字: ");
        input = Console.ReadLine();
        #region HIGHLIGHT
        if (double.TryParse(input, out number))
        {
            // 转换正确，现在开始使用数字
            // ...
        }
        else
        #endregion HIGHLIGHT
        {
            Console.WriteLine(
                "输入的文本不是一个有效的数字。");
        }
        #endregion INCLUDE
    }
}
