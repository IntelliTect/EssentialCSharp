namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter03.Listing03_16;

public class Program
{
    public static void Main()
    {
        #region INCLUDE
        // ERROR: Each dimension must be consistently sized
        #if COMPILEERROR // EXCLUDE
        int[,] cells = {
            {1, 0, 2, 0},
            {1, 2, 0},
            {1, 2},
            {1}
        };
        #endif // COMPILEERROR // EXCLUDE
        #endregion INCLUDE
    }
}
