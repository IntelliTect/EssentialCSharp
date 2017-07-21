namespace AddisonWesley.Michaelis.EssentialCSharp.Shared.Listing18_16
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {

        public void ShowParallelLinq(List<string> data)
        {
            ParallelQuery<IGrouping<char, string>> parallelGroups;
            parallelGroups =
                from text in data.AsParallel()
                orderby text
                group text by text[0];

            // Show the total count of items still
            // matches the original count
            //System.Diagnostics.Trace.Assert(
            //    data.Count == parallelGroups.Sum(
            //    item => item.Count()));
        }

        public void ShowSynchronousLinq(List<string> data)
        {
            IEnumerable<IGrouping<char, string>> parallelGroups =
                from text in data
                orderby text
                group text by text[0];
        }

        private static List<string> GetRandomNumbers()
        {
            List<string> numbers = new List<string>();
            Random random = new Random();
            for (int index = 0; index < 1000000; index++)
            {
                numbers.Add(random.Next().ToString());
            }

            return numbers;
        }

        public static void Main()
        {
            Program program = new Program();
            List<string> data = GetRandomNumbers();
            DateTime synchronousTimeBefore = DateTime.Now;
            program.ShowSynchronousLinq(data);
            DateTime synchronousTimeAfter = DateTime.Now;

            DateTime parallelTimeBefore = DateTime.Now;
            program.ShowParallelLinq(data);
            DateTime parallelTimeAfter = DateTime.Now;

            //System.Diagnostics.Trace.Assert(orderedNumbersForParallel.SequenceEqual(orderedNumbersForSynchronous));
            Console.WriteLine();
            Console.WriteLine(string.Format("Time for synchronous OrderBy was {0}.", (synchronousTimeAfter - synchronousTimeBefore).TotalSeconds));
            Console.WriteLine(string.Format("Time for parallel OrderBy was {0}.", (parallelTimeAfter - parallelTimeBefore).TotalSeconds));
            Console.WriteLine();
        }
    }
}
