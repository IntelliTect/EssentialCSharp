namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter04.Listing04_45;

public class DoWhileLoop
{
    public static void Main()
    {
        int currentPlayer = 1;
        #region INCLUDE        
        // 反复提示玩家落子，直到
        // 输入棋盘上的一个有效位置。
        bool valid;
        do
        {
            valid = false;

            // 请求当前玩家落子
            Console.Write(
                $"玩家{currentPlayer}: 输入落子:");
            string? input = Console.ReadLine();

            // 检查当前玩家的输入
            // ...

        } while(!valid);
        #endregion INCLUDE
    }
}
