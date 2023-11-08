namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter13.Listing13_02;

#region INCLUDE
public class SimpleSort2
{
    public enum SortType
    {
        Ascending,
        Descending
    }

    #region HIGHLIGHT
    public static void BubbleSort(int[] items, SortType sortOrder)
    #endregion HIGHLIGHT
    {
        int i;
        int j;
        int temp;

        if(items is null)
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
                    #region HIGHLIGHT
                    case SortType.Ascending:
                        swap = items[j - 1] > items[j];
                        #endregion HIGHLIGHT
                        break;

                    #region HIGHLIGHT
                    case SortType.Descending:
                        swap = items[j - 1] < items[j];
                        #endregion HIGHLIGHT
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
#endregion INCLUDE
