namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter13.Listing13_07;

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
    {
        return first > second;
    }
    #endregion HIGHLIGHT

    // ...
}
#endregion INCLUDE
