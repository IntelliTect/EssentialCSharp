namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter04.Listing04_17;

public class Program
{
    public static void Main()
    {
        #region INCLUDE
        int count = 123;
        int result;
        #region HIGHLIGHT
        result = ++count;
        #endregion HIGHLIGHT
        Console.WriteLine(
            $"result = {result} and count = {count}");
        #endregion INCLUDE
    }
}
