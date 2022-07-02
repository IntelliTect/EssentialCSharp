namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter19.Listing19_02
{
    using AddisonWesley.Michaelis.EssentialCSharp.Shared;
    using System;
    using System.Threading.Tasks;

    public class Program
    {
        public static void Main()
        {
            // Use Task.Factory.StartNew<string>() for
            // TPL prior to .NET 4.5
            Task<string> task =
                Task.Run<string>(
                    () => PiCalculator.Calculate(100));

            foreach (
                char busySymbol in Utility.BusySymbols())
            {
                if (task.IsCompleted)
                {
                    Console.Write('\b');
                    break;
                }
                Console.Write(busySymbol);
            }

            Console.WriteLine();

            Console.WriteLine(task.Result);
            if (!task.IsCompleted)
            {
                throw new Exception("Task Should Be Completed");
            }
        }
    }
}