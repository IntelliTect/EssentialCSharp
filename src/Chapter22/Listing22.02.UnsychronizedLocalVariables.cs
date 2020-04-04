namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter22.Listing22_02
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;

    public class Program
    {
        static public CancellationToken CancellationToken;

        public static int Main(string[] args)
        {
            int total = int.MaxValue;
            int x = 0;
            if (args?.Length > 0) { int.TryParse(args[0], out total); }
            Console.WriteLine($"Increment and decrementing {total} times...");

            Parallel.For(0, total, 
                new ParallelOptions() { CancellationToken = CancellationToken}
                , i =>
            {
                x++;
                x--;
            });
            Console.WriteLine("Count = {0}", x);
            return x;
        }
    }
}
