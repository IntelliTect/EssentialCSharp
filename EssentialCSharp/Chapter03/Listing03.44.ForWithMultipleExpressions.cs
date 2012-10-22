namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter03.Listing03_44
{ 
    public class Program
    { 
        public static void Main()
        {
            for (int x = 0, y = 5; ((x <= 5) && (y >= 0)); y--, x++)
            {
                System.Console.Write("{0}{1}{2}\t",
                    x, (x > y ? '>' : '<'), y);
            }
        }
    }
}
