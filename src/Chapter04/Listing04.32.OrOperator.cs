namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter03.Listing03_32
{
    public class Program
    {
        public static void Main()
        {
            if ((hourOfTheDay > 23) || (hourOfTheDay < 0))
                System.Console.WriteLine("The time you entered is invalid.");
        }

        public static int hourOfTheDay { get; set; }
    }
}
