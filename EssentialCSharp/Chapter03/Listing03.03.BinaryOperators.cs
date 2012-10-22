namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter03.Listing03_03
{
    public class Division
    {
        public static void Main()
        {
            int numerator;
            int denominator;
            int quotient;
            int remainder;

            System.Console.Write("Enter the numerator: ");
            numerator = int.Parse(System.Console.ReadLine());

            System.Console.Write("Enter the denominator: ");
            denominator = int.Parse(System.Console.ReadLine());

            quotient = numerator / denominator;
            remainder = numerator % denominator;

            System.Console.WriteLine(
                "{0} / {1} = {2} with remainder {3}",
                numerator, denominator, quotient, remainder);
        }
    }
}
