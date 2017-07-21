namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter03.Listing03_46
{
    public class Program
    {
        public static void Main()
        {
            // ...

            bool valid = false;

            // Check the current player's input.
            if((input == "1") ||
                (input == "2") ||
                (input == "3") ||
                (input == "4") ||
                (input == "5") ||
                (input == "6") ||
                (input == "7") ||
                (input == "8") ||
                (input == "9"))
            {
                // Save/move as the player directed.
                // ...

                valid = true;
            }
            else if((input == "") || (input == "quit"))
            {
                valid = true;
            }
            else
            {
                System.Console.WriteLine(
                  "\nERROR:  Enter a value from 1-9. "
                  + "Push ENTER to quit");
            }

            // ...
        }

        public static string input { get; set; }
    }
}
