namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter03.Listing03_33
{
    public class Program
    {
        public static void Main()
        {
            if((10 < hourOfTheDay) && (hourOfTheDay < 24))
                System.Console.WriteLine(
                    "Hi-Ho, Hi-Ho, it's off to work we go.");
        }

        public static int hourOfTheDay { get; set; }
    }
}
