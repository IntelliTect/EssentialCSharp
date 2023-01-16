namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter13.Listing13_19;

using System;
#region INCLUDE
public class DelegateSample
{
    #region EXCLUDE
    public delegate bool ComparisonHandler(int first, int second);

    public static void BubbleSort(
        int[] items, ComparisonHandler comparisonMethod)
    {
        int i;
        int j;
        int temp;

        for(i = items.Length - 1; i >= 0; i--)
        {
            for(j = 1; j <= i; j++)
            {
                if(comparisonMethod(items[j - 1], items[j]))
                {
                    temp = items[j - 1];
                    items[j - 1] = items[j];
                    items[j] = temp;
                }
            }
        }
    }
    #endregion EXCLUDE

    public static void Main()
    {
        int[] items = new int[5];

        for(int i = 0; i < items.Length; i++)
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
        BubbleSort(items,
            __AnonymousMethod_00000000);
        #endregion HIGHLIGHT


        for (int i = 0; i < items.Length; i++)
        {
            Console.WriteLine(items[i]);
        }

    }
    #region HIGHLIGHT
    private static bool __AnonymousMethod_00000000(
        int first, int second)
    {
        return first < second;
    }
    #endregion HIGHLIGHT
}
#endregion INCLUDE
