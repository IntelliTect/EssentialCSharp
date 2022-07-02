// TODO: Update listing in Manuscript
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter13.Listing13_20
{
    using Listing13_11;
    using System;

    public class Program
    {
        public static void Main()
        {
            int[] items = new int[5];
            int comparisonCount = 0;

            for (int i = 0; i < items.Length; i++)
            {
                Console.Write("Enter an integer:");
                string? text = Console.ReadLine();
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

            for (int i = 0; i < items.Length; i++)
            {
                Console.WriteLine(items[i]);
            }

            Console.WriteLine("Items were compared {0} times.",
                comparisonCount);
        }
    }
}