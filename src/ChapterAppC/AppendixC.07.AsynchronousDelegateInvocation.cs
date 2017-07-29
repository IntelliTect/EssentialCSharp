namespace AddisonWesley.Michaelis.EssentialCSharp.AppendixC.ListingC_07
{
    using System;
    using AddisonWesley.Michaelis.EssentialCSharp.Shared;

    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Application started....");

            Func<int, string> workerMethod = null;
            IAsyncResult asyncResult = null;

            workerMethod = PiCalculator.Calculate;
            Console.WriteLine("Starting thread....");
            asyncResult =
                workerMethod.BeginInvoke(500, null, null);

            // Display periods as progress bar.
            while(!asyncResult.AsyncWaitHandle.WaitOne(100))
            {
                Console.Write('.');
            }
            Console.WriteLine();
            Console.WriteLine("Thread ending....");
            Console.WriteLine(
                workerMethod.EndInvoke(asyncResult));

            Console.WriteLine("Application shutting down....");
        }
    }
}






