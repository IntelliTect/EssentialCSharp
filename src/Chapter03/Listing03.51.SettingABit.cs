namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter03.Listing03_49
{
    public class Program
    {
        public static void Main()
        {
            string input = "";

            int shifter;  // The number of places to shift 
                          // over to set a bit.
            int position; // The bit that is to be set.

            // int.Parse() converts "input" to an integer.
            // "int.Parse(input) - 1" because arrays 
            // are zero based.
            shifter = int.Parse(input) - 1;

            // Shift mask of 00000000000000000000000000000001
            // over by cellLocations.
            position = 1 << shifter;

            // Take the current player cells and OR them to set the
            // new position as well.
            // Since currentPlayer is either 1 or 2,
            // subtract 1 to use currentPlayer as an
            // index in a zero based array.
            playerPositions[currentPlayer - 1] |= position;
        }

        public static int[] playerPositions { get; set; }
        public static int currentPlayer { get; set; }
    }
}
