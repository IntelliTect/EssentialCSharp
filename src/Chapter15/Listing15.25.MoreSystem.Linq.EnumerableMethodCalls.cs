namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter15.Listing15_25
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            IEnumerable<object> stuff =
                new object[] { new object(), 1, 3, 5, 7, 9,
                    "\"thing\"", Guid.NewGuid() };
            Print("Stuff: {0}", stuff);

            IEnumerable<int> even = new int[] { 0, 2, 4, 6, 8 };
            Print("Even integers: {0}", even);

            IEnumerable<int> odd = stuff.OfType<int>();
            Print("Odd integers: {0}", odd);

            IEnumerable<int> numbers = even.Union(odd);
            Print("Union of odd and even: {0}", numbers);

            Print("Union with even: {0}", numbers.Union(even));
            Print("Concat with odd: {0}", numbers.Concat(odd));
            Print("Intersection with even: {0}",
                numbers.Intersect(even));
            Print("Distinct: {0}", numbers.Concat(odd).Distinct());

            if (!numbers.SequenceEqual(
                numbers.Concat(odd).Distinct()))
            {
                throw new Exception("Unexpectedly unequal");
            }
            else
            {
                Console.WriteLine(
                    @"Collection ""SequenceEquals""" +
                    $" {nameof(numbers)}.Concat(odd).Distinct())");
            }
            Print("Reverse: {0}", numbers.Reverse());
            Print("Average: {0}", numbers.Average());
            Print("Sum: {0}", numbers.Sum());
            Print("Max: {0}", numbers.Max());
            Print("Min: {0}", numbers.Min());

        }

        private static void Print<T>
            (
                string format, IEnumerable<T> items)
                where T : notnull =>
            Console.WriteLine(format, string.Join(
                ", ", items.Select(x => x.ToString())));

        private static void Print<T>(string format, T item)
        {
            Console.WriteLine(format, item);
        }
    }
}
