namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter12.Listing12_16
{
    using System;
    using Listing12_10;

    public class Program
    {
        public static void Main()
        {
            int i;
            int[] items = new int[5];

            for(i = 0; i < items.Length; i++)
            {
                Console.Write("Enter an integer:");
                items[i] = int.Parse(Console.ReadLine());
            }

            DelegateSample.BubbleSort(items,
                delegate(int first, int second)
                {
                    return first < second;
                }
            );

            for(i = 0; i < items.Length; i++)
            {
                Console.WriteLine(items[i]);
            }
        }
    }
}