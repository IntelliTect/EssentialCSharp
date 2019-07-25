namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter04.Listing04_49
{
    public class Program
    {
        public static void Main()
        {
            // ...
        }

        public static bool ValidateAndMove(
            int[] playerPositions, int currentPlayer, string input)
        {
            bool valid = false;

            // Check the current player's input
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
                    // Save/move as the player directed
                    // ...
                    valid = true;
                    break;
                case "":
                case "quit":
                    valid = true;
                    break;
                default:
                    // If none of the other case statements
                    // is encountered then the text is invalid
                    System.Console.WriteLine(
                    "\nERROR:  Enter a value from 1-9. "
                    + "Push ENTER to quit");
                    break;
            }

            return valid;
        }
    }
}