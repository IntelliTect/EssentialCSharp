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

        // ��ڶ�������([1])�ĵ�һ��[0]Ԫ�ظ�ֵ
        cells[1][0] = 0;

        // ...
        #endregion INCLUDE
    }
}
