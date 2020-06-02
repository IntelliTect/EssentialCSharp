namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter04.Listing04_32
{
    public class Program
    {
        public static void Main(params string[] args)
        {
            int hourOfTheDay = int.Parse(args[0]);

            if ((hourOfTheDay > 23) || (hourOfTheDay < 0))
                System.Console.WriteLine("The time you entered is invalid.");
        }
    }
}
