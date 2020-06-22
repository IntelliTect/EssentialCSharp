namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter03.Listing03_29
{
    public class Program
    {
        public static void Main()
        {
            bool[, ,] cells;
            cells = new bool[2, 3, 3];
            System.Console.WriteLine(cells.GetLength(0));  // Displays 2
            System.Console.WriteLine(cells.Rank);  // Displays 3
        }
    }
}
