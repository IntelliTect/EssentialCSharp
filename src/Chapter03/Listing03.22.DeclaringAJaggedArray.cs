namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter03.Listing03_22;

public class Program
{
    public static void Main()
    {
        #region INCLUDE
        int[][] cells = {
            new []{1, 0, 2},
            new []{0, 2, 0},
            new []{1, 2, 1}
        };

        cells[1][0] = 1;
        // ...
        #endregion INCLUDE
    }
}
