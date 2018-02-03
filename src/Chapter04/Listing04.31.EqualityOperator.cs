namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter03.Listing03_31
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

        public static string input { get; set; }
        public static object[] currentPlayer { get; set; }
    }
}
