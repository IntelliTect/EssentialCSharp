namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter03.Listing03_21;

public class Program
{
    public static void Main()
    {
        #region INCLUDE
        int[,] cells = {
            {1, 0, 2},
            {0, 2, 0},
            {1, 2, 1}
        };
        // 将井字棋的决胜走棋设为玩家1，
        // 因为玩家1只需在第二行(索引1)的第一列(索引0)落子，即获胜。
        cells[1, 0] = 1;
        #endregion INCLUDE
    }
}
