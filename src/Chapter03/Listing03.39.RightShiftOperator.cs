namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter03.Listing03_37
{
    public class Program
    {
        public static void Main()
        {
            int x;
            x = (-7 >> 2); // 11111111111111111111111111111001 becomes 
                           // 11111111111111111111111111111110
            // Write out "x is -2."
            System.Console.WriteLine($"x = { x }.");
        }
    }
}
