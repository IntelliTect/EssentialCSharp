namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter03.Listing03_28;

public class Program
{
    public static void Main()
    {
        #region INCLUDE
        bool[, ,] cells;
        cells = new bool[2, 3, 3];
        Console.WriteLine(cells.GetLength(0)); // ��ʾ2
        Console.WriteLine(cells.Rank); // ��ʾ3
        #endregion INCLUDE
    }
}
