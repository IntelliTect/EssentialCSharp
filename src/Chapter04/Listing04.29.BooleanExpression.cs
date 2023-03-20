namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter04.Listing04_29;

public class Program
{
    public static void Main()
    {
        int input = 5;

        #region INCLUDE
        #region HIGHLIGHT
        if (input < 9)
        #endregion HIGHLIGHT
        {
            // Input is less than 9
            Console.WriteLine(
                $"Tic-tac-toe has more than {input}" +
                 " maximum turns.");
        }
        // ...
        #endregion INCLUDE
    }
}
