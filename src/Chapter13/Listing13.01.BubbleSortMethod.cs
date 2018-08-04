namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter13.Listing13_01
{
    static class SimpleSort1
    {
        public static void BubbleSort(int[] items)
        {
            int i;
            int j;
            int temp;

            if(items == null)
            {
                return;
            }

            for(i = items.Length - 1; i >= 0; i--)
            {
                for(j = 1; j <= i; j++)
                {
                    if(items[j - 1] > items[j])
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