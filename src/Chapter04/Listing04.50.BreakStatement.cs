namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter04.Listing04_50
{
    public class TicTacToe      // Declares the TicTacToe class
    {
        public static void Main()
        {
            int winner = 0;
            // Stores locations each player has moved
            int[] playerPositions = { 0, 0 };

            // Hardcoded board position
            //  X | 2 | O 
            // ---+---+---
            //  O | O | 6 
            // ---+---+---
            //  X | X | X 
            playerPositions[0] = 449;
            playerPositions[1] = 28;

            // Determine if there is a winner
            int[] winningMasks = {
                7, 56, 448, 73, 146, 292, 84, 273 };

            // Iterate through each winning mask to determine
            // if there is a winner
            foreach(int mask in winningMasks)
            {
                if((mask & playerPositions[0]) == mask)
                {
                    winner = 1;
                    break;
                }
                else if((mask & playerPositions[1]) == mask)
                {
                    winner = 2;
                    break;
                }
            }

            System.Console.WriteLine(
                $"Player { winner } was the winner");
        }
    }
}