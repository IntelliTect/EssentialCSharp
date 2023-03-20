namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter15.Listing15_11;

using AddisonWesley.Michaelis.EssentialCSharp.Chapter15.Listing15;
#region INCLUDE
using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        IEnumerable<Patent> patents = PatentData.Patents;
        IEnumerable<Patent> patentsOf1800 = patents.Where(
            patent => patent.YearOfPublication.StartsWith("18"));
        #region HIGHLIGHT
        IEnumerable<string> items = patentsOf1800.Select(
            patent => patent.ToString());
        #endregion HIGHLIGHT

        Print(items);
    }
    #region EXCLUDE

    private static void Print<T>(IEnumerable<T> items)
    {
        foreach(T item in items)
        {
            Console.WriteLine(item);
        }
    }
    #endregion EXCLUDE
}
#endregion INCLUDE
