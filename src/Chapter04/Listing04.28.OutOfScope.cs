// Justification: Checking for null isn't discussed yet.
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type
// Justification: args is declared and referenced in the manuscript but now used because the listing is incomplete.
#pragma warning disable IDE0060 // Remove unused parameter
// Justification: Attempting to use message outside of it's scope so it goes unused.
#pragma warning disable CS0219  // Variable is assigned but its value is never used

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter04.Listing04_28;

public class Program
{
    public static void Main(string[] args)
    {
        #region INCLUDE
        string playerCount;
        Console.Write(
            "Enter the number of players (1 or 2):");
        playerCount = Console.ReadLine();
        if (playerCount != "1" && playerCount != "2")
        {
            #region HIGHLIGHT
            string message =
                "You entered an invalid number of players.";
            #endregion HIGHLIGHT
        }
        else
        {
            // ...
        }
        #if COMPILEERROR  //EXCLUDE
        #region HIGHLIGHT
        // ERROR: message is not in scope:
        Console.WriteLine(message);
        #endregion HIGHLIGHT
        #endif // COMPILEERROR  //EXCLUDE
        #endregion INCLUDE
    }
}
