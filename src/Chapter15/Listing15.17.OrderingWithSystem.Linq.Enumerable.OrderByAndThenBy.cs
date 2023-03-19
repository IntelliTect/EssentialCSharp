namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter15.Listing15_17;

using AddisonWesley.Michaelis.EssentialCSharp.Chapter15.Listing15;
#region INCLUDE
using System;
using System.Collections.Generic;
using System.Linq;
#region EXCLUDE
public class Program
{
    public static void Main()
    {
        #endregion EXCLUDE
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

        //...
        #endregion INCLUDE
    }

    private static void Print<T>(IEnumerable<T> items)
    {
        foreach(T item in items)
        {
            Console.WriteLine(item);
        }
    }
}
