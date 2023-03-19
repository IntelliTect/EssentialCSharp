namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter04.Listing04_49;

public class Program
{
    public static void Main(params string[] args)
    {
        string input = args[0];
        #region INCLUDE
        // ...

        // Check the current player's input
        if ((input == "1") ||
            (input == "2") ||
            (input == "3") ||
            (input == "4") ||
            (input == "5") ||
            (input == "6") ||
            (input == "7") ||
            (input == "8") ||
            (input == "9"))
        {
            // Save/move as the player directed
            // ...

        }
        else if((input.Length == 0) || (input == "quit"))
        {
            // Retry or quite
            // ...

        }
        else
        {
            Console.WriteLine( $"""
                    ERROR:  Enter a value from 1-9.
                    Push ENTER to quit
                    """);
        }

        // ...
        #endregion INCLUDE
    }
}
