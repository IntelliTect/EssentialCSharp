namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter15.Listing15_15;

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
        Console.WriteLine($"Patent Count: { patents.Count() }");
        #endregion HIGHLIGHT
        Console.WriteLine($@"Patent Count in 1800s: {
            patents.Count(patent =>
                patent.YearOfPublication.StartsWith("18"))}");
        #endregion INCLUDE
    }
}
