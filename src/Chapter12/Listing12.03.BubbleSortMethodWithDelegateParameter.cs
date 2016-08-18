namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter12.Listing12_03
{
    using System;
    using Listing12_07;

    class DelegateSample
    {
        // ...

        public static void BubbleSort(
            int[] items, ComparisonHandler comparisonMethod)
        {
            int i;
            int j;
            int temp;


            if(comparisonMethod == null)
            {
                throw new ArgumentNullException("comparisonMethod");
            }

            if(items == null)
            {
                return;
            }

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
        // ...
    }
}