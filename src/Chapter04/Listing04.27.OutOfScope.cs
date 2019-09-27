#pragma warning disable CS0219 // Variable is assigned but its value is never used
#pragma warning disable CS0168 // Variable is declared but never used
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter04.Listing04_27
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int playerCount;
            System.Console.Write(
                "Enter the number of players (1 or 2):");
            playerCount = int.Parse(System.Console.ReadLine());
            if(playerCount != 1 && playerCount != 2)
            {
                string message =
                    "You entered an invalid number of players.";
            }
            else
            {
                // ...
            }

            // Error: message is not in scope:
            //System.Console.WriteLine(message);
        }
    }
}
