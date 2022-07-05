namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter13.Listing13_17
{
    using System;
    using Listing13_11;
    #region INCLUDE
    #region EXCLUDE
    public class Program
    {
        public static void Main()
        {
            int[] items = new int[5];

            for(int i = 0; i < items.Length; i++)
            {
                Console.Write("Enter an integer:");
                string? text = Console.ReadLine();
                if (!int.TryParse(text, out items[i]))
                {
                    Console.WriteLine($"'{text}' is not a valid integer.");
                    return;
                }
            }
            #endregion EXCLUDE
            DelegateSample.BubbleSort(items,
                delegate(int first, int second)
                {
                    return first < second;
                }
            );
            #region EXCLUDE

            for (int i = 0; i < items.Length; i++)
            {
                Console.WriteLine(items[i]);
            }
        }
    }
    #endregion EXCLUDE
    #endregion INCLUDE
}