namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter13.Listing13_16
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
            #region HIGHLIGHT
            DelegateSample.BubbleSort
                (items, (first, second) => first < second);
            #endregion HIGHLIGHT
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