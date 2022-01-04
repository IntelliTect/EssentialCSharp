namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter04.Listing04_44
{
    public class Program
    {
        public static void Main()
        {
            int currentPlayer = 1;
                
            // Repeatedly request player to move until he
            // enters a valid position on the board
            bool valid;
            do
            {
                valid = false;

                // Request a move from the current player
                System.Console.Write(
                    $"\nPlayer {currentPlayer}: Enter move:");
                // TODO: Update listing in Manuscript
                string input = System.Console.ReadLine() ?? string.Empty;

                // Check the current player's input
                // ...

            } while(!valid);
        }
    }
}
