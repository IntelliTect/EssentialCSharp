namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter13.Listing13_21;

using System;
using Listing13_11;
public class Program
{
    public static void Main()
    {
        int[] items = new int[5];

        for (int i = 0; i < items.Length; i++)
        {
            Console.Write("Enter an integer:");
            string? text = Console.ReadLine();
            if (!int.TryParse(text, out items[i]))
            {
                Console.WriteLine($"'{text}' is not a valid integer.");
                return;
            }
        }

        #region INCLUDE
        int comparisonCount = 0;
        
        DelegateSample.BubbleSort(items,
        #region HIGHLIGHT
            static (int first, int second) =>
        #endregion HIGHLIGHT
            {
                #if COMPILEERROR // EXCLUDE
                // Error CS8820: A static anonymous function
                // cannot contain a reference to comparisonCount.
                comparisonCount++;
                #endif // COMPILEERROR // EXCLUDE
                return first < second;
            }
        );

        for (int i = 0; i < items.Length; i++)
        {
            Console.WriteLine(items[i]);
        }

        #region HIGHLIGHT
        Console.WriteLine("Items were compared {0} times.",
            comparisonCount);
        #endregion HIGHLIGHT
    }
}
#endregion INCLUDE
