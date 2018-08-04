namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter13.Listing13_16
{
    using System;
    using Listing13_11;

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

            DelegateSample.BubbleSort(items, (first, second) => first < second);

            for(i = 0; i < items.Length; i++)
            {
                Console.WriteLine(items[i]);
            }
        }
    }
}