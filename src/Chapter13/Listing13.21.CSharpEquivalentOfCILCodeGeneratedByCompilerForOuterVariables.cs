namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter13.Listing13_21
{
    using System;
    using Listing13_11;

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
            int i;
            __LocalsDisplayClass_00000001 locals =
                new __LocalsDisplayClass_00000001();
            locals.comparisonCount = 0;
            int[] items = new int[5];

            for(i = 0; i < items.Length; i++)
            {
                Console.Write("Enter an integer:");
                items[i] = int.Parse(Console.ReadLine());
            }

            DelegateSample.BubbleSort(items, locals.__AnonymousMethod_00000000);

            for(i = 0; i < items.Length; i++)
            {
                Console.WriteLine(items[i]);
            }

            Console.WriteLine("Items were compared {0} times.",
                locals.comparisonCount);
        }
    }
}