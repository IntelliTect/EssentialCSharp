namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter04.Listing04_48;

public class TicTacToe // 声明TicTacToe类
{
    public static void Main() // 声明程序的入口点
    {
        #region INCLUDE
        // 像下面这样硬编码初始棋盘
        // ---+---+---
        //  1 | 2 | 3
        // ---+---+---
        //  4 | 5 | 6
        // ---+---+---
        //  7 | 8 | 9
        // ---+---+---
        char[] cells = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };

        Console.Write("可能的落子如下所示: ");


        // 输出初始可能的落子
        foreach (char cell in cells)
        {
            if(cell != 'O' && cell != 'X')
            {
                Console.Write($"{ cell } ");
            }
        }
        #endregion INCLUDE
    }
}
