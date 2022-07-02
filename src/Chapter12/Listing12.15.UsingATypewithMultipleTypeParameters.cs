namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter12.Listing12_15
{
    using Listing12_14;
    using System;

    public class Program
    {
        public static void Main()
        {
            #region INCLUDE
            Pair<int, string> historicalEvent =
                new Pair<int, string>(1914,
                    "Shackleton leaves for South Pole on ship Endurance");

            Console.WriteLine("{0}: {1}",
                historicalEvent.First, historicalEvent.Second);
            #endregion INCLUDE
        }
    }
}
