namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter15.Listing15_10;

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
        #region HIGHLIGHT
        patents = patents.Where(
            patent => patent.YearOfPublication.StartsWith("18"));
        #endregion HIGHLIGHT
        Print(patents);
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
