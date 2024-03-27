namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter04.Listing04_24;

public class Program
{
    public static void Main(params string[] args)
    {
        int input = int.Parse(args[0]);

        #region INCLUDE
        if (input < 0)
            #region HIGHLIGHT
            Console.WriteLine("Exiting");
            #endregion HIGHLIGHT
        #endregion INCLUDE
    }
}
