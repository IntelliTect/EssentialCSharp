// Justification: Checking for null isn't discussed yet.
#pragma warning disable CS8604 // Possible null reference argument
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter04.Listing04_22;

public class TicTacToeTrivia
{
    public static void Main()
    {
        #region INCLUDE
        int input;    // 声明一个变量来存储用户输入

        Console.Write(
            "井字棋最多能走" +
            "多少步?" +
            " (输入0退出): ");

        // int.Parse()将ReadLine()的
        // 返回值转换为int
        input = int.Parse(Console.ReadLine());

        // 条件1
        if (input <= 0)
            // 输入小于等于0
            Console.WriteLine("退出...");
        else
            // 条件2
            if (input < 9)
            // 输入小于9
            Console.WriteLine(
                "井字棋最大步数" +
                $"大于{input}");
        else
                // 条件3
                if (input > 9)
            // 输入大于9
            Console.WriteLine(
                "井字棋最大步数" +
                $"小于{input}");
        // 条件4
        else
            // 输入等于9
            Console.WriteLine(
                "正确，井字棋最多" +
                "只能走9步。");
        #endregion INCLUDE
    } 
}
