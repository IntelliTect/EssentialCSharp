// Justification: args is declared and referenced in the manuscript but now used because the listing is incomplete.
#pragma warning disable IDE0060 // Remove unused parameter
// Justification: Attempting to use message outside of it's scope so it goes unused.
#pragma warning disable CS0219  // Variable is assigned but its value is never used

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter04.Listing04_27
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string playerCount;
            System.Console.Write(
                "Enter the number of players (1 or 2):");
            playerCount = System.Console.ReadLine();
            if (playerCount != "1" && playerCount != "2")
            {
                string message =
                    "You entered an invalid number of players.";
            }
            else
            {
                // ...
            }

            // ERROR: message is not in scope:
            // System.Console.WriteLine(message);
        }
    }
}
