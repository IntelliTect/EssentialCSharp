namespace AddisonWesley.Michaelis.EssentialCSharp.Shared
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;

    static class Utility
    {
        public static void DisplayComparison(string title, long synchElapsed, long parallelElapsed)
        {
            string message = string.Format("synchronous {0} > {1} parallel by {2}%",
                synchElapsed, parallelElapsed,
                (double)parallelElapsed / (double)synchElapsed);

            Console.WriteLine("\n{0} ({1}:", title, message);
        }

        public static long MeasureElapsedTime(Action action)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            action();
            stopwatch.Stop();
            return stopwatch.ElapsedMilliseconds;
        }

        public static IEnumerable<char> BusySymbols()
        {
            string busySymbols = @"-\|/-\|/";
            int next = 0;
            while(true)
            {
                yield return busySymbols[next];
                next = (++next) % busySymbols.Length;
                yield return '\b';
            }
        }
    }
}
