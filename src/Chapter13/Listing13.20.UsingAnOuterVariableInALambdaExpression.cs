namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter13.Listing13_20;

using System;
using Listing13_11;
#region INCLUDE
public class Program
{
    public static void Main()
    {
        int[] items = new int[5];
        #region HIGHLIGHT
        int comparisonCount = 0;
        #endregion HIGHLIGHT

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

        #region HIGHLIGHT
        DelegateSample.BubbleSort(items,
            (int first, int second) =>
            {
                comparisonCount++;
                return first < second;
            }
        );
        #endregion HIGHLIGHT

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
