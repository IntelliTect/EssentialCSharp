namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter13.Listing13_22;

using System;
using Listing13_11;
#region INCLUDE
public class Program
{
    // ...
    #region HIGHLIGHT
    private sealed class __LocalsDisplayClass_00000001
    {
        public int comparisonCount;
        public bool __AnonymousMethod_00000000(
            int first, int second)
        {
            comparisonCount++;
            return first < second;
        }
    }
    #endregion HIGHLIGHT

    public static void Main()
    {
        #region HIGHLIGHT
        __LocalsDisplayClass_00000001 locals = new();
        locals.comparisonCount = 0;
        #endregion HIGHLIGHT
        int[] items = new int[5];

        for (int i = 0; i < items.Length; i++)
        {
            Console.Write("Enter an integer: ");
            string? text = Console.ReadLine();
            if (!int.TryParse(text, out items[i]))
            {
                Console.WriteLine($"'{text}' is not a valid integer.");
                return;
            }
        }

        #region HIGHLIGHT
        DelegateSample.BubbleSort
            (items, locals.__AnonymousMethod_00000000);
        #endregion HIGHLIGHT
        for (int i = 0; i < items.Length; i++)
        {
            Console.WriteLine(items[i]);
        }

        #region HIGHLIGHT
        Console.WriteLine("Items were compared {0} times.",
            locals.comparisonCount);
        #endregion HIGHLIGHT
    }
}
#endregion INCLUDE
