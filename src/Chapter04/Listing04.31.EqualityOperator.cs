namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter04.Listing04_31
{
    public class Program
    {
        public static void Main(params string[] args)
        {
            string input = args[0];
            string currentPlayer = args[1];

            if (input.Length == 0 || input == "quit")
            {
                System.Console.WriteLine($"Player {currentPlayer} quit!!");
            }
        }
    }
}
