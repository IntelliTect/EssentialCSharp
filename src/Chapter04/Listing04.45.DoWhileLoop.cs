namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter04.Listing04_45;

public class DoWhileLoop
{
    public static void Main()
    {
        int currentPlayer = 1;
        #region INCLUDE
        // Repeatedly request player to move until he
        // enters a valid position on the board
        bool valid;
        do
        {
            valid = false;

            // Request a move from the current player
            Console.Write(
                $"Player {currentPlayer}: Enter move:");
            string? input = Console.ReadLine();

            // Check the current player's input
            // ...

        } while(!valid);
        #endregion INCLUDE
    }
}
