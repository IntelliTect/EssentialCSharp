// Justification: Checking for null isn't discussed yet.
#pragma warning disable CS8604 // Possible null reference argument
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter04.Listing04_03;

public class Division
{
    public static void Main()
    {
        #region INCLUDE
        int numerator;
        int denominator;
        int quotient;
        int remainder;

        Console.Write("Enter the numerator: ");
        numerator = int.Parse(Console.ReadLine());

        Console.Write("Enter the denominator: ");
        denominator = int.Parse(Console.ReadLine());

        #region HIGHLIGHT
        quotient = numerator / denominator;
        remainder = numerator % denominator;
        #endregion HIGHLIGHT

        Console.WriteLine(
            $"{numerator} / {denominator} = {
                quotient} with remainder {remainder}");
        #endregion INCLUDE
    }
}