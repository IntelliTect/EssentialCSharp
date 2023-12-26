namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter04.Listing04_52;

public class Program
{
    public static void Main()
    {

        int[] playerPositions = { 0, 0 };
        int currentPlayer = 1;
        string input = "";

        #region INCLUDE
        int shifter;  // 要移多少位来设置一个bit
        int position; // 要设置的bit

        // int.Parse() 将"input"转换为整数。
        // 之所以要用"int.Parse(input) - 1"，是因为
        // 数组基于零。
        shifter = int.Parse(input) - 1;

        // 使掩码00000000000000000000000000000001
        // 移位单元格的位置。
        position = 1 << shifter;

        // 取当前玩家的单元格，并对它们进行
        // 按位或（OR）运算，以设置新的位置。
        // 由于currentPlayer要么是1，要么是2，
        // 因此要减去1，才能将currentPlayer
        // 用作零基数组的索引。
        playerPositions[currentPlayer - 1] |= position;
        #endregion INCLUDE
    }
}
