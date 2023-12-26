namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter04.Listing04_49;

public class Program
{
    public static void Main(params string[] args)
    {
        string input = args[0];
        #region INCLUDE
        // ...

        // 检查当前玩家的输入
        if ((input == "1") ||
            (input == "2") ||
            (input == "3") ||
            (input == "4") ||
            (input == "5") ||
            (input == "6") ||
            (input == "7") ||
            (input == "8") ||
            (input == "9"))
        {
            // 根据玩家的输入保存/落子
            // ...

        }
        else if((input.Length == 0) || (input == "quit"))
        {
            // 重试或退出
            // ...

        }
        else
        {
            Console.WriteLine( $"""
                    错误:  输入1-9的值。
                    按Enter键退出。
                    """);
        }

        // ...
        #endregion INCLUDE
    }
}
