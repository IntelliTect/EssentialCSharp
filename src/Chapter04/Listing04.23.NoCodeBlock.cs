namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter04.Listing04_23
{
    public class Program
    {
        public static void Main(params string[] args)
        {
            int input = int.Parse(args[0]);

            if(input < 9)
                System.Console.WriteLine("Exiting");
        }
    }
}
