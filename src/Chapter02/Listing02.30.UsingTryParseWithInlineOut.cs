namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter02.Listing02_30
{
    public class Program
    {
        public static void Main()
        {
            // double number;
            string input;

            System.Console.Write("Enter a number: ");
            input = System.Console.ReadLine();
            if (double.TryParse(input, out double number))
            {
                System.Console.WriteLine(
                    $"input was parsed successfully to {number}.");
            }
            else
            {
                // Note: number scope is here too (although not assigned)
                System.Console.WriteLine(
                    "The text entered was not a valid number.");
            }

            System.Console.WriteLine(
                $"'number' currently has the value: {number}");
        }
    }
}
