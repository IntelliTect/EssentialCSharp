namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter02.Listing02_36;

public class Program
{
    public static void Main()
    {
        #region INCLUDE
        // double number;
        string input;

        Console.Write("Enter a number: ");
        input = Console.ReadLine();
        if (double.TryParse(input, out double number))
        {
            Console.WriteLine(
            #region HIGHLIGHT
                $"input was parsed successfully to {number}.");
            #endregion HIGHLIGHT
        }
        else
        {
            // Note: number scope is here too (although not assigned)
            Console.WriteLine(
                "The text entered was not a valid number.");
        }

        Console.WriteLine(
            $"'number' currently has the value: {number}");
        #endregion INCLUDE
    }
}
