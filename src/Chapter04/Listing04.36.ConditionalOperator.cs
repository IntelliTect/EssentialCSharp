namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter04.Listing04_36;

#region INCLUDE
public class TicTacToe
{
    public static void Main()
    {
        // 最开始将currentPlayer设为玩家1
        int currentPlayer = 1;

        // ...

        for(int turn = 1; turn <= 10; turn++)
        {
            // ...

            // 交换玩家
            currentPlayer = (currentPlayer == 2) ? 1 : 2;
        }
    }
}
#endregion INCLUDE
