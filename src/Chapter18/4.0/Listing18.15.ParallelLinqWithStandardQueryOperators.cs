using System.IO;

namespace AddisonWesley.Michaelis.EssentialCSharp.Shared.Listing18_15
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {

        public static void ShowParallelLinq(List<string> data)
        {
            OrderedParallelQuery<string> parallelGroups = data.AsParallel().OrderBy(item => item);

            // Show the total count of items still
            // matches the original count
            //System.Diagnostics.Trace.Assert(
            //  data.Count == parallelGroups.Sum(
            //      item => item.Count()));

        }

        public static void ShowSynchronousLinq(List<string> data)
        {
            IOrderedEnumerable<string> orderedEnumerable = data.OrderBy(item => item);
        }

        private static List<string> GetRandomNumbers()
        {
            List<string> numbers = new List<string>();
            Random random = new Random();
            for(int index = 0; index < 1000000; index++)
            {
                numbers.Add(random.Next().ToString());
            }

            return numbers;
        }

        public static void Main()
        {
            List<string> numbersForParallel = GetRandomNumbers();
            List<string> numbersForSynchronous = new List<string>(numbersForParallel);

            DateTime synchronousTimeBefore = DateTime.Now;
            ShowSynchronousLinq(numbersForSynchronous);
            DateTime synchronousTimeAfter = DateTime.Now;
            
            DateTime parallelTimeBefore = DateTime.Now;
            ShowParallelLinq(numbersForParallel);
            DateTime parallelTimeAfter = DateTime.Now;

            //System.Diagnostics.Trace.Assert(orderedNumbersForParallel.SequenceEqual(orderedNumbersForSynchronous));
            Console.WriteLine();
            Console.WriteLine(string.Format("Time for synchronous OrderBy was {0}.", (synchronousTimeAfter - synchronousTimeBefore).TotalSeconds));
            Console.WriteLine(string.Format("Time for parallel OrderBy was {0}.", (parallelTimeAfter - parallelTimeBefore).TotalSeconds));
            Console.WriteLine();

        }
    }
}
