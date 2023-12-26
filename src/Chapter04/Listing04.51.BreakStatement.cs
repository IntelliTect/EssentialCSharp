namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter04.Listing04_51;

public class TicTacToe // 声明TicTacToe类
{
    public static void Main() // 声明程序的入口点
    {
        #region INCLUDE
        int winner = 0;
        // 存储每个玩家的落子位置
        int[] playerPositions = { 0, 0 };

        // 硬编码的棋盘位置
        //  X | 2 | O 
        // ---+---+---
        //  O | O | 6 
        // ---+---+---
        //  X | X | X 
        playerPositions[0] = 449;
        playerPositions[1] = 28;

        // 判断是否出现了一个赢家
        int[] winningMasks = {
            7, 56, 448, 73, 146, 292, 84, 273 };

        // 遍历每个致胜掩码(winning mask)，
        // 判断是否有一位赢家
        #region HIGHLIGHT
        foreach (int mask in winningMasks)
        {
            #endregion HIGHLIGHT
            if ((mask & playerPositions[0]) == mask)
            {
                winner = 1;
                #region HIGHLIGHT
                break;
                #endregion HIGHLIGHT
            }
            else if((mask & playerPositions[1]) == mask)
            {
                winner = 2;
                #region HIGHLIGHT
                break;
                #endregion HIGHLIGHT
            }
            #region HIGHLIGHT
        }
        #endregion HIGHLIGHT

        Console.WriteLine($"玩家{ winner }是赢家。");
        #endregion INCLUDE
    }
}
