// TODO: Update listing in Manuscript
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter13.Listing13_21
{
    using Listing13_11;
    using System;

    public class Program
    {
        // ...
        private sealed class __LocalsDisplayClass_00000001
        {
            public int comparisonCount;
            public bool __AnonymousMethod_00000000(
                int first, int second)
            {
                comparisonCount++;
                return first < second;
            }
        }

        public static void Main()
        {
            __LocalsDisplayClass_00000001 locals =
                new __LocalsDisplayClass_00000001();
            locals.comparisonCount = 0;
            int[] items = new int[5];

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

            DelegateSample.BubbleSort(items, locals.__AnonymousMethod_00000000);

            for (int i = 0; i < items.Length; i++)
            {
                Console.WriteLine(items[i]);
            }

            Console.WriteLine("Items were compared {0} times.",
                locals.comparisonCount);
        }
    }
}