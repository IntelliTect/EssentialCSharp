namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter15.Listing15_09
{
    using AddisonWesley.Michaelis.EssentialCSharp.Chapter15.Listing15;
    using System;
    using System.Collections.Generic;

    public class Program
    {
        public static void Main()
        {
            IEnumerable<Patent> patents = PatentData.Patents;
            Print(patents);

            Console.WriteLine();

            IEnumerable<Inventor> inventors = PatentData.Inventors;
            Print(inventors);
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
