// Justification: Inline variable declaration not explained yet.
#pragma warning disable IDE0018 // Inline variable declaration
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter02.Listing02_35;

public class Program
{
    public static void Main()
    {
        #region INCLUDE
        double number;
        string input;

        Console.Write("Enter a number: ");
        input = Console.ReadLine();
        #region HIGHLIGHT
        if (double.TryParse(input, out number))
        {
            // Converted correctly, now use number
            // ...
        }
        else
        #endregion HIGHLIGHT
        {
            Console.WriteLine(
                "The text entered was not a valid number.");
        }
        #endregion INCLUDE
    }
}
