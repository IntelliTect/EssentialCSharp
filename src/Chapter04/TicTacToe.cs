
#define CSHARP2PLUS

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter04.TicTacToe
{
    using System;

#pragma warning disable 1030 // Disable user-defined warnings

    // The TicTacToe class enables two players to 
    // play tic-tac-toe.
    public class TicTacToeGame      // Declares the TicTacToeGame class.
    {
        static public void Main()  // Declares the entry point to the program.
        {
            // Stores locations each player has moved.
            int[] playerPositions = { 0, 0 };

            // Initially set the currentPlayer to Player 1.
            int currentPlayer = 1;

            // Winning player
            int winner = 0;

            string input = "Let the game begin!";

            // Display the board and 
            // prompt the current player
            // for his next move.
            for(int turn = 1; turn <= 10; ++turn)
            {
                DisplayBoard(playerPositions);

                #region Check for End Game
                if(EndGame(winner, turn, input))
                {
                    break;
                }
                #endregion Check for End Game

                input = NextMove(playerPositions, currentPlayer);

                winner = DetermineWinner(playerPositions);

                // Switch players.
                currentPlayer = (currentPlayer == 2) ? 1 : 2;
            }
        }

        private static string NextMove(int[] playerPositions,
                       int currentPlayer)
        {
            string input;

            // Repeatedly prompt the player for a move
            // until a valid move is entered.
            bool validMove;
            do
            {
                // Request a move from the current player.
                System.Console.Write($"\nPlayer {currentPlayer} - Enter move:");
                input = System.Console.ReadLine();
                validMove = ValidateAndMove(playerPositions,
                              currentPlayer, input);
            } while(!validMove);

            return input;
        }

        static bool EndGame(int winner, int turn, string input)
        {
            bool endGame = false;
            if(winner > 0)
            {
                System.Console.WriteLine($"\nPlayer {winner} has won!!!!");
                endGame = true;
            }
            else if(turn == 10)
            {
                // After completing the 10th display of the
                // board, exit rather than prompting the
                // user again.
                System.Console.WriteLine("\nThe game was a tie!");
                endGame = true;
            }
            else if(input.Length == 0 || input == "quit")
            {
                // Check if user quit by hitting Enter without 
                // any characters or by typing "quit".
                System.Console.WriteLine("The last player quit");
                endGame = true;
            }
            return endGame;
        }

        static int DetermineWinner(int[] playerPositions)
        {
            int winner = 0;

            // Determine if there is a winner.
            int[] winningMasks = {
          7, 56, 448, 73, 146, 292, 84, 273};

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
            return winner;
        }

        static bool ValidateAndMove(
          int[] playerPositions, int currentPlayer, string input)
        {
            bool valid = false;

            // Check the current player’s input.
            switch(input)
            {
                case "1":
                case "2":
                case "3":
                case "4":
                case "5":
                case "6":
                case "7":
                case "8":
                case "9":
#warning  "Same move allowed multiple times."
                    int shifter;  // The number of places to shift 
                    // over to set a bit.
                    int position;  // The bit which is to be set.

                    // int.Parse() converts "input" to an integer.
                    // "int.Parse(input) – 1" because arrays 
                    // are zero-based.
                    shifter = int.Parse(input) - 1;

                    // Shift mask of 00000000000000000000000000000001
                    // over by cellLocations.
                    position = 1 << shifter;

                    // Take the current player cells and OR them 
                    // to set the new position as well.
                    // Since currentPlayer is either 1 or 2 you 
                    // subtract 1 to use currentPlayer as an
                    // index in a zero-based array.
                    playerPositions[currentPlayer - 1] |= position;

                    valid = true;
                    break;

                case "":
                case "quit":
                    valid = true;
                    break;

                default:
                    // If none of the other case statements
                    // is encountered, then the text is invalid.
                    System.Console.WriteLine(
                        "\nERROR:  Enter a value from 1-9. "
                        + "Push ENTER to quit");
                    break;
            }

            return valid;
        }

        static void DisplayBoard(int[] playerPositions)
        {
            // This represents the borders between each cell
            // for one row.
            string[] borders = {
  "|", "|", "\n---+---+---\n", "|", "|",
  "\n---+---+---\n", "|", "|", ""
  };

            // Display the current board;
            int border = 0;  // set the first border (border[0] = "|").

#if CSHARP2PLUS
            System.Console.Clear();
#endif

            for(int position = 1;
                 position <= 256;
                 position <<= 1, border++)
            {
                char token = CalculateToken(
                    playerPositions, position);

                // Write out a cell value and the border that 
                // comes after it.
                System.Console.Write($" {token} {borders[border]}");
            }
        }

        static char CalculateToken(
            int[] playerPositions, int position)
        {
            // Initialize the players to 'X' and 'O'
            char[] players = { 'X', 'O' };

            char token;
            // If player has the position set, 
            // then set the token to that player.
            if((position & playerPositions[0]) == position)
            {
                // Player 1 has that position marked.
                token = players[0];
            }
            else if((position & playerPositions[1]) == position)
            {
                // Player 2 has that position marked.
                token = players[1];
            }
            else
            {
                // The position is empty.
                token = ' ';
            }
            return token;
        }

#line 113 "TicTacToe.cs"
        // Generated code goes here.
#line default
    }
}