namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter03.Listing03_18;

public class Program
{
    public static void Main()
    {
        #region INCLUDE
        int[][] cells = {
            new [] {1, 0, 2, 0},
            new [] {1, 2, 0},
            new [] {1, 2},
            new [] {1}
        };

        // 利用C# 12.0的集合初始化语法，可以简化成：
        // int[][] cells = {
        //    [1, 0, 2, 0],
        //    [1, 2, 0],
        //    [1, 2],
        //    [1]
        // };

        #endregion INCLUDE
    }
}
