namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter15.Listing15_29
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        public static void Main()
        {
            var worldCup2006Finalists = new[]
            {
                new
                {
                    TeamName = "France",
                    Players = new string[]
                    {
                        "Fabien Barthez", "Gregory Coupet",
                        "Mickael Landreau", "Eric Abidal",
                        // ...
                    }
                },
                new
                {
                    TeamName = "Italy",
                    Players = new string[]
                    {
                        "Gianluigi Buffon", "Angelo Peruzzi",
                        "Marco Amelia", "Cristian Zaccardo",
                        // ...
                    }
                }
            };

            Print(worldCup2006Finalists);
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
