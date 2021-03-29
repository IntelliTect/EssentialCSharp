namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter03.Listing03_01
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int? number = null;

            // ...
            if (args.Length > 0)
            {
                number = args[0].Length;
            }

            if (number is null)
            {
                System.Console.WriteLine(
                    "'number' requires a value and cannot be null");
            }
            else
            {
                System.Console.WriteLine(
                    $"'number' doubled is { number * 2 }.");
            }

        }
    }
}

