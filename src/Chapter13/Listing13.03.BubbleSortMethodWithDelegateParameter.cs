namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter13.Listing13_03
{
    using System;

    class DelegateSample
    {
        // ...

        public static void BubbleSort(
            int[] items, Func<int, int, bool> compare)
        {
            int i;
            int j;
            int temp;


            if(compare == null)
            {
                throw new ArgumentNullException(nameof(compare));
            }

            if(items == null)
            {
                return;
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
        // ...
    }
}