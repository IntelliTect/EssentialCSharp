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
        // ��������ľ�ʤ������Ϊ���1��
        // ��Ϊ���1ֻ���ڵڶ���(����1)�ĵ�һ��(����0)���ӣ�����ʤ��
        cells[1, 0] = 1;
        #endregion INCLUDE
    }
}
