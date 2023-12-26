namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter04.Listing04_50;

public class Program
{
    public static void Main()
    {
        // ...
    }

    #region INCLUDE
    public static bool ValidateAndMove(
        int[] playerPositions, int currentPlayer, string input)
    {
        bool valid = false;

        // 检查当前玩家的输入
        switch (input)
        {
            case "1":
            case "2":
            case "3":
            case "4":
            case "5":
            case "6":
            case "7":
            case "8":
            case "9":
                // 根据玩家的输入保存/落子
                // ...
                valid = true;
                break;
            case "":
            case "quit":
                valid = true;
                break;
            default:
                // 如果和其他case都不匹配，表明输入无效
                Console.WriteLine(
                "错误:  输入1-9的值。 "
                + "按Enter键退出。");
                break;
        }

        return valid;
    }
    #endregion INCLUDE
}
