namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter03.Listing03_22;

public class Program
{
    public static void Main()
    {
        #region INCLUDE
        int[][] cells = {
            [1, 0, 2, 0],
            [1, 2, 0],
            [1, 2],
            [1]
        };

        // 向第二个数组([1])的第一个[0]元素赋值
        cells[1][0] = 0;

        // ...
        #endregion INCLUDE
    }
}
