namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter04.Listing04_20
{
    public class TicTacToe // Declares the TicTacToe class
    {
        public static void Main() // Declares the entry point of the program
        {
            string input;

            // Prompt the user to select a 1- or 2- player game
            System.Console.Write(
                "1 - Play against the computer\n" +
                "2 - Play against another player.\n" +
                "Choose:"
            );
            input = System.Console.ReadLine();

            if(input == "1")
                // The user selected to play the computer
                System.Console.WriteLine(
                    "Play against computer selected.");
            else
                // Default to 2 players (even if user didn't enter 2)
                System.Console.WriteLine(
                    "Play against another player.");
        }
    }

}
