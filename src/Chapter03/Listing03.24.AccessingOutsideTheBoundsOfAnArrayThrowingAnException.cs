namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter03.Listing03_24;

public class Program
{
    public static void Main()
    {
        #region INCLUDE
        string[] languages = new string[9];
        // ...
        // RUNTIME ERROR: index out of bounds - should
        // be 8 for the last element
        languages[4] = languages[9];
        #endregion INCLUDE
    }
}
