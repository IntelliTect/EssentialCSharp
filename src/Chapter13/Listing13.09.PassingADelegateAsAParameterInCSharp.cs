namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter13.Listing13_09;

using System;
using Listing13_05;

public class DelegateSample
{
    public static void BubbleSort(
        int[] items, Comparer compare)
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

    public static bool GreaterThan(int first, int second)
    {
        return first > second;
    }

    public static void Main()
    {
        int i;
        int[] items = new int[100];
        Random random = new();

        for(i = 0; i < items.Length; i++)
        {
            items[i] = random.Next(int.MinValue, int.MaxValue);
        }
        #region INCLUDE
        BubbleSort(items,
            new Comparer(GreaterThan));
        #endregion INCLUDE
        for (i = 0; i < items.Length; i++)
        {
            Console.WriteLine(items[i]);
        }
    }
}