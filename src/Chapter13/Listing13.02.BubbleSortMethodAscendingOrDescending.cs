namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter13.Listing13_02
{
    class SimpleSort2
    {
        public enum SortType
        {
            Ascending,
            Descending
        }

        public static void BubbleSort(int[] items, SortType sortOrder)
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

                    bool swap = false;
                    switch(sortOrder)
                    {
                        case SortType.Ascending:
                            swap = items[j - 1] > items[j];
                            break;

                        case SortType.Descending:
                            swap = items[j - 1] < items[j];
                            break;
                    }

                    if(swap)
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