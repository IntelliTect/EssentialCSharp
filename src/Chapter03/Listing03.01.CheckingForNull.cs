namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter03.Listing03_01
{
    public class Program
    {
        public static void Main()
        {
            int? number = null;
            // ...
            if (number is null)
            {
                System.Console.WriteLine(
                    $"{ nameof(number) } requires a value and cannot be null");
            }
            else
            {
                System.Console.WriteLine(
                    $"{ nameof(number) } is of type { number.GetType() }.");
            }

        }
    }
}

