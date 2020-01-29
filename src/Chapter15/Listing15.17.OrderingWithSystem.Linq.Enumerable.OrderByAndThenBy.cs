namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter15.Listing15_17
{
    using AddisonWesley.Michaelis.EssentialCSharp.Chapter15.Listing15;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            IEnumerable<Patent> items;
            Patent[] patents = PatentData.Patents;
            items = patents.OrderBy(
                    patent => patent.YearOfPublication)
                .ThenBy(
                    patent => patent.Title);
            Print(items);
            Console.WriteLine();

            items = patents.OrderByDescending(
                    patent => patent.YearOfPublication)
                .ThenByDescending(
                    patent => patent.Title);
            Print(items);
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
