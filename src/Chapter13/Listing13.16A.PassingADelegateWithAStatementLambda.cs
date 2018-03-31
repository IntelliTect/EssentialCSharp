namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter13.Listing13_16A
{
    using System;
    using Listing13_03;

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
                (int first, int second) =>
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
