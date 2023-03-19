namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter04.Listing04_32;

public class Program
{
    public static void Main(params string[] args)
    {
        string input = args[0];
        string currentPlayer = args[1];
        #region INCLUDE
        if (input.Length == 0 || input == "quit")
        {
            Console.WriteLine($"Player {currentPlayer} quit!!");
        }
        #endregion INCLUDE
    }
}
