namespace AddisonWesley.Michaelis.EssentialCSharp.Shared.Listing18_02
{
    using System;
    using System.Diagnostics;
    using System.Threading.Tasks;

    public class Program
    {
        public static void Main()
        {
            Task<string> task = Task.Factory.StartNew<string>(
                () => PiCalculator.Calculate(100));

            foreach (char busySymbol in Utility.BusySymbols())
            {
                if (task.IsCompleted)
                {
                    Console.Write('\b');
                    break;
                }
                Console.Write(busySymbol);
            }

            Console.WriteLine();
            // Blocks until task completes.
            Console.WriteLine(task.Result);
            Trace.Assert(task.IsCompleted);
        }
    }
}
