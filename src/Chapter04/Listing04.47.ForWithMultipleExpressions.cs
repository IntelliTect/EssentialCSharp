namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter04.Listing04_47;

public class Program
{
    public static void Main()
    {
        #region INCLUDE
        for (int x = 0, y = 5; ((x <= 5) && (y >= 0)); y--, x++)
        {
            Console.Write(
                $"{ x }{ ((x > y)  ? '>' : '<')}{ y }\t");
        }
        #endregion INCLUDE
    }
}
