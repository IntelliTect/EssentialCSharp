namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter13.Listing13_20
{
    using System;
    using Listing13_11;

    public class Program
    {
        public static void Main()
        {
            int i;
            string? text;
            int[] items = new int[5];
            int comparisonCount = 0;

            for(i = 0; i < items.Length; i++)
            {
                Console.Write("Enter an integer:");
                text = Console.ReadLine();
                if (!int.TryParse(text, out items[i]))
                {
                    Console.WriteLine($"'{text}' is not a valid integer.");
                    return;
                }
            }

            DelegateSample.BubbleSort(items,
                (int first, int second) =>
                {
                    comparisonCount++;
                    return first < second;
                }
            );

            for(i = 0; i < items.Length; i++)
            {
                Console.WriteLine(items[i]);
            }

            Console.WriteLine("Items were compared {0} times.",
                comparisonCount);
        }
    }
}