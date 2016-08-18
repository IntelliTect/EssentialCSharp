namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter18.Listing18_04
{
    using System;
    using System.Threading.Tasks;
    using AddisonWesley.Michaelis.EssentialCSharp.Shared;

    public class Program
    {
        public static void ChapterMain()
        {
            // Use Task.Factory.StartNew<string>() for
            // TPL prior to .NET 4.5
            Task<string> task =
                Task.Run<string>(
                    () => PiCalculator.Calculate(100));

            foreach(
                char busySymbol in Utility.BusySymbols())
            {
                if(task.IsCompleted)
                {
                    Console.Write('\b');
                    break;
                }
                Console.Write(busySymbol);
            }

            Console.WriteLine();

            Console.WriteLine(task.Result);
        }
    }
}