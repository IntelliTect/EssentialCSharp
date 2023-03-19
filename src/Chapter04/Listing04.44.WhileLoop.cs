namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter04.Listing04_44;

public class FibonacciCalculator
{
    public static void Main()
    {
        #region INCLUDE
        decimal current;
        decimal previous;
        decimal temp;
        decimal input;

        Console.Write("Enter a positive integer:");

        // decimal.Parse convert the ReadLine to a decimal
        // If ReadLine returns null, use "42" as default input
        input = decimal.Parse(Console.ReadLine() ?? "42");

        // Initialize current and previous to 1, the first
        // two numbers in the Fibonacci series
        current = previous = 1;

        // While the current Fibonacci number in the series is
        // less than the value input by the user
        while (current <= input)
        {
            temp = current;
            current = previous + current;
            previous = temp; // Executes even if previous
            // statement caused current to exceed input
        }

        Console.WriteLine(
                  $"The Fibonacci number following this is { current }");
        #endregion INCLUDE
    }
}
