namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter04.Listing04_09;

public class Program
{
    public static void Main()
    {
        #region INCLUDE
        // Displays: -Infinity
        Console.WriteLine(-1f / 0);
        // Displays: Infinity
        Console.WriteLine(3.402823E+38f * 2f);
        #endregion INCLUDE
    }
}
