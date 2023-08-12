namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter12.Listing12_15;

using System;
using Listing12_14;

public class Program
{
    public static void Main()
    {
        #region INCLUDE
        Pair<int, string> historicalEvent =
            new(1914,
                "Shackleton leaves for South Pole on ship Endurance");

        Console.WriteLine("{0}: {1}",
            historicalEvent.First, historicalEvent.Second);
        #endregion INCLUDE
    }
}
