namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter13.Listing13_03;

using System;
#region INCLUDE
public class DelegateSample
{
    // ...

    #region HIGHLIGHT
    public static void BubbleSort(
    #endregion HIGHLIGHT
        int[] items, Func<int, int, bool> compare)
    {
        int i;
        int j;
        int temp;

        if(compare is null)
        {
            throw new ArgumentNullException(nameof(compare));
        }

        if(items is null)
        {
            return;
        }

        for(i = items.Length - 1; i >= 0; i--)
        {
            for(j = 1; j <= i; j++)
            {
                #region HIGHLIGHT
                if (compare(items[j - 1], items[j]))
                #endregion HIGHLIGHT
                {
                    temp = items[j - 1];
                    items[j - 1] = items[j];
                    items[j] = temp;
                }
            }
        }
    }
    // ...
}
#endregion INCLUDE
