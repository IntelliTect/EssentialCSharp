namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter20.Listing20_02
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;

#pragma warning disable CA2211 //Non-constant fields should not be visible

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

#pragma warning restore CA2211
}
