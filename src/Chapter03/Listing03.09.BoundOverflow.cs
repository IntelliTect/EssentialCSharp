namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter03.Listing03_09
{
    public class Program
    {
        public static void Main()
        {
            // Displays: -Infinity
            System.Console.WriteLine(-1f / 0);
            // Displays: Infinity
            System.Console.WriteLine(3.402823E+38f * 2f);
        }
    }
}
