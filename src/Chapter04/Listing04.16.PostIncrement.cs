namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter04.Listing04_16;

public class Program
{
    public static void Main()
    {
        #region INCLUDE
        int count = 123;
        int result;
        result = count++;
        Console.WriteLine(
              $"result = {result} and count = {count}");
        #endregion INCLUDE
    }
}
