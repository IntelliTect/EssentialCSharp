namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter15.Listing15_10
{
    using AddisonWesley.Michaelis.EssentialCSharp.Chapter15.Listing15;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            IEnumerable<Patent> patents = PatentData.Patents;
            patents = patents.Where(
                patent => patent.YearOfPublication.StartsWith("18"));
            Print(patents);
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
