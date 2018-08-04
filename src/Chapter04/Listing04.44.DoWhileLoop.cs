namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter04.Listing04_44
{
    public class Program
    {
        public static void Main()
        {
            // Repeatedly request player to move until he
            // enters a valid position on the board
            bool valid;
            do
            {
                valid = false;

                // Request a move from the current player
                System.Console.Write(
                    $"\nPlayer {currentPlayer}: Enter move:");
                string input = System.Console.ReadLine();

                // Check the current player's input
                // ...

            } while(!valid);
        }

        public static object[] currentPlayer { get; set; }
    }
}
