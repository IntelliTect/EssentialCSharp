namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter13.Listing13_08;

using System;
#region INCLUDE
public class DelegateSample
{
    public static void BubbleSort(
        int[] items, Func<int, int, bool> compare)
    #region EXCLUDE
    {
        int i;
        int j;
        int temp;

        if(items is null)
        {
            return;
        }
        if(compare is null)
        {
            throw new ArgumentNullException(nameof(compare));
        }

        for(i = items.Length - 1; i >= 0; i--)
        {
            for(j = 1; j <= i; j++)
            {
                if(compare(items[j - 1], items[j]))
                {
                    temp = items[j - 1];
                    items[j - 1] = items[j];
                    items[j] = temp;
                }
            }
        }
    }
    #endregion EXCLUDE
    #region HIGHLIGHT
    public static bool GreaterThan(int first, int second)
    #endregion HIGHLIGHT
    {
        return first > second;
    }

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
        BubbleSort(items, GreaterThan);
        #endregion HIGHLIGHT

        for (int i = 0; i < items.Length; i++)
        {
            Console.WriteLine(items[i]);
        }
    }
}
#endregion INCLUDE
