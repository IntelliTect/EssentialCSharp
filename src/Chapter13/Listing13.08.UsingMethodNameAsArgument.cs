namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter13.Listing13_08
{
    using System;

    class DelegateSample
    {
        public static void BubbleSort(
            int[] items, Func<int, int, bool> compare)
        {
            int i;
            int j;
            int temp;

            if(items == null)
            {
                return;
            }
            if(compare == null)
            {
                throw new ArgumentNullException(nameof(compare));
            }

            for(i = items.Length - 1; i >= 0; i--)
            {
                for(j = 1; j <= i; j++)
                {
                    if(compare(items[j - 1], items[j]))
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

        static void Main()
        {
            int i;
            string? text;
            int[] items = new int[5];

            for(i = 0; i < items.Length; i++)
            {
                Console.Write("Enter an integer: ");
                text = Console.ReadLine();
                if (!int.TryParse(text, out items[i]))
                {
                    Console.WriteLine($"'{text}' is not a valid integer.");
                    return;
                }
            }

            BubbleSort(items, GreaterThan);

            for(i = 0; i < items.Length; i++)
            {
                Console.WriteLine(items[i]);
            }
        }
    }
}