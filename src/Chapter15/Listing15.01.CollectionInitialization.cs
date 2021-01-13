namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter15.Listing15_01
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        public static void Main()
        {
            List<string> sevenWorldBlunders;
            sevenWorldBlunders = new List<string>()
            {
                // Quotes from Gandhi
                "Wealth without work",
                "Pleasure without conscience",
                "Knowledge without character",
                "Commerce without morality",
                "Science without humanity",
                "Worship without sacrifice",
                "Politics without principle"
            };

            Print(sevenWorldBlunders);
        }

        private static void Print<T>(IEnumerable<T> items)
        {
            foreach(T item in items)
            {
                Console.WriteLine(item);
            }
        }
    }
}
