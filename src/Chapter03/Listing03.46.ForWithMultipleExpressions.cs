namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter03.Listing03_44
{
    public class Program
    {
        public static void Main()
        {
            for (int x = 0, y = 5; ((x <= 5) && (y >= 0)); y--, x++)
            {
                System.Console.Write(
                    $"{ x }{ ((x > y)  ? '>' : '<')}{y}\t");
            }
        }
    }
}
