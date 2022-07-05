namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter04.Listing04_50
{
    #region INCLUDE
    public class TicTacToe // Declares the TicTacToe class
    {
        public static void Main() // Declares the entry point of the program
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
            #region HIGHLIGHT
            foreach (int mask in winningMasks)
            {
                #endregion
                if ((mask & playerPositions[0]) == mask)
                {
                    winner = 1;
                    #region HIGHLIGHT
                    break;
                    #endregion
                }
                else if ((mask & playerPositions[1]) == mask)
                {
                    winner = 2;
                    #region HIGHLIGHT
                    break;
                    #endregion
                }
                #region HIGHLIGHT
            }
            #endregion

            System.Console.WriteLine(
                $"Player {winner} was the winner");
        }
    }
    #endregion
}