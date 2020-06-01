namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter04.Listing04_31
{
    public class Program
    {
        public static void Main()
        {
            if(input == "" || input == "quit")
            {
                System.Console.WriteLine($"Player {currentPlayer} quit!!");
            }
        }

#pragma warning disable IDE1006 // Promoted local variables to properties to support testing sample code
        public static string input { get; set; } = "Let the game begin!";
        public static string? currentPlayer { get; set; }
#pragma warning restore IDE1006 // Naming Styles
    }
}
