namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter13.Listing13_19
{
    using System;

    public class DelegateSample
    {
        #region Members
        public delegate bool ComparisonHandler(int first, int second);

        public static void BubbleSort(
            int[] items, ComparisonHandler comparisonMethod)
        {
            int i;
            int j;
            int temp;

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
        #endregion Members

        public static void Main()
        {
            int i;
            int[] items = new int[5];

            for(i = 0; i < items.Length; i++)
            {
                Console.Write("Enter an integer:");
                items[i] = int.Parse(Console.ReadLine());
            }

            BubbleSort(items,
                DelegateSample.__AnonymousMethod_00000000);


            for(i = 0; i < items.Length; i++)
            {
                Console.WriteLine(items[i]);
            }

        }

        private static bool __AnonymousMethod_00000000(
            int first, int second)
        {
            return first < second;
        }
    }
}