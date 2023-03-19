// Justification: Checking for null isn't discussed yet.
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter04.Listing04_21;

public class TicTacToe // Declares the TicTacToe class
{
    public static void Main() // Declares the entry point of the program
    {
        #region INCLUDE
        string input;

        // Prompt the user to select a 1- or 2- player game
        Console.Write($"""
                1 - Play against the computer
                2 - Play against another player.
                Choose:
                """
        );
        input = Console.ReadLine();

        #region HIGHLIGHT
        if (input == "1")
            // The user selected to play the computer
            Console.WriteLine(
                "Play against computer selected.");
        else
            // Default to 2 players (even if user didn't enter 2)
            Console.WriteLine(
                "Play against another player.");
        #endregion HIGHLIGHT
        #endregion INCLUDE
    }
}
