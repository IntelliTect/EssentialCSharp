// Justification: Checking for null isn't discussed yet.
#pragma warning disable CS8604 // Possible null reference argument
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter04.Listing04_03
{
    #region INCLUDE
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

            #region HIGHLIGHT
            quotient = numerator / denominator;
            remainder = numerator % denominator;
            #endregion HIGHLIGHT

            System.Console.WriteLine(
                $"{numerator} / {denominator} = {quotient} with remainder {remainder}");
        }
    }
    #endregion INCLUDE
}