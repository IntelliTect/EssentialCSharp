namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter15.Listing15_25;

#region INCLUDE
using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        IEnumerable<object> stuff =
            new object[] { new(), 1, 3, 5, 7, 9,
                "\"thing\"", Guid.NewGuid() };
        Print("Stuff: {0}", stuff);

        IEnumerable<int> even = new int[] { 0, 2, 4, 6, 8 };
        Print("Even integers: {0}", even);

        #region HIGHLIGHT
        IEnumerable<int> odd = stuff.OfType<int>();
        #endregion HIGHLIGHT
        Print("Odd integers: {0}", odd);

        #region HIGHLIGHT
        IEnumerable<int> numbers = even.Union(odd);
        #endregion HIGHLIGHT
        Print("Union of odd and even: {0}", numbers);

        #region HIGHLIGHT
        Print("Union with even: {0}", numbers.Union(even));
        Print("Concat with odd: {0}", numbers.Concat(odd));
        #endregion HIGHLIGHT
        Print("Intersection with even: {0}",
        #region HIGHLIGHT
            numbers.Intersect(even));
        Print("Distinct: {0}", numbers.Concat(odd).Distinct());
        #endregion HIGHLIGHT

        #region HIGHLIGHT
        if (!numbers.SequenceEqual(
            numbers.Concat(odd).Distinct()))
        #endregion HIGHLIGHT
        {
            throw new Exception("Unexpectedly unequal");
        }
        else
        {
            Console.WriteLine(
                @"Collection ""SequenceEquals""" +
                $" {nameof(numbers)}.Concat(odd).Distinct())");
        }
        #region HIGHLIGHT
        Print("Reverse: {0}", numbers.Reverse());
        Print("Average: {0}", numbers.Average());
        Print("Sum: {0}", numbers.Sum());
        Print("Max: {0}", numbers.Max());
        Print("Min: {0}", numbers.Min());
        #endregion HIGHLIGHT
    }

    private static void Print<T>(
            string format, IEnumerable<T> items)
            where T : notnull =>
        Console.WriteLine(format, string.Join(
            ", ", items));
    #region EXCLUDE

    private static void Print<T>(string format, T item)
    {
        Console.WriteLine(format, item);
    }
    #endregion EXCLUDE
}
#endregion INCLUDE
