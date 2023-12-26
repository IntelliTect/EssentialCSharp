// Justification: Checking for null isn't discussed yet.
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter04.Listing04_21;

public class TicTacToe // 声明TicTacToe类
{
    public static void Main() // 声明程序的入口点
    {
        #region INCLUDE
        string input;

        // 提示用户选择单人还是双人游戏
        Console.Write($"""
                1 - 人机对战
                2 - 双人对战
                请选择：
                """
        );
        input = Console.ReadLine();

        #region HIGHLIGHT
        if (input == "1")
            // 用户选择人机对战
            Console.WriteLine("人机对战。");
        else
            // 其他情况都默认双人对战(即使用户输入的不是2)
            Console.WriteLine("双人对战。");
        #endregion HIGHLIGHT
        #endregion INCLUDE
    }
}
