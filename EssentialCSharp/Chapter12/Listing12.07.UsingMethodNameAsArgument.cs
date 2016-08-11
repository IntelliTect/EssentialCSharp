namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter12.Listing12_07
{
    using System;

    public delegate bool ComparisonHandler(
        int first, int second);

    class DelegateSample
    {
        public static void BubbleSort(
            int[] items, ComparisonHandler comparisonMethod)
        {
            int i;
            int j;
            int temp;

            if(items == null)
            {
                return;
            }
            if(comparisonMethod == null)
            {
                throw new ArgumentNullException("comparisonMethod");
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

        public static bool GreaterThan(int first, int second)
        {
            return first > second;
        }

        static void ChapterMain()
        {
            int i;
            int[] items = new int[5];

            for(i = 0; i < items.Length; i++)
            {
                Console.Write("Enter an integer: ");
                items[i] = int.Parse(Console.ReadLine());
            }

            BubbleSort(items, GreaterThan);

            for(i = 0; i < items.Length; i++)
            {
                Console.WriteLine(items[i]);
            }
        }
    }
}