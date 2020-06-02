namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter04.Listing04_33
{
    public class Program
    {
        public static void Main(params string[] args)
        {
            int hourOfTheDay = int.Parse(args[0]);

            if ((10 < hourOfTheDay) && (hourOfTheDay < 24))
                System.Console.WriteLine(
                    "Hi-Ho, Hi-Ho, it's off to work we go.");
        }
    }
}
