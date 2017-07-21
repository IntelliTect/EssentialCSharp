namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter11.Listing11_15
{
    using System;
    using Listing11_14;

    public class Program
    {
        public static void Main()
        {
            Pair<int, string> historicalEvent =
                new Pair<int, string>(1914,
                    "Shackleton leaves for South Pole on ship Endurance");

            Console.WriteLine("{0}: {1}",
                historicalEvent.First, historicalEvent.Second);
        }
    }
}