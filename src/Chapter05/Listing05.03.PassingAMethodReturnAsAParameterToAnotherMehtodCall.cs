namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter05.Listing05_03;

public class Program
{
    #region INCLUDE
    public static void Main()
    {
        Console.Write("Enter your first name: ");
        #region HIGHLIGHT
        Console.WriteLine($"Hello { Console.ReadLine() }!");
        #endregion HIGHLIGHT
    }
    #endregion INCLUDE
}
