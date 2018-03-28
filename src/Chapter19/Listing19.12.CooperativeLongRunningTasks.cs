namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter19.Listing19_12
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;
    using AddisonWesley.Michaelis.EssentialCSharp.Shared;

    public class Program
    {
        public static void Main()
        {
            string stars =
                "*".PadRight(Console.WindowWidth - 1, '*');
            Console.WriteLine("Push ENTER to exit.");

            CancellationTokenSource cancellationTokenSource =
                new CancellationTokenSource();

            // Use Task.Factory.StartNew<string>() for
            // TPL prior to .NET 4.5
            Task task = Task.Factory.StartNew(
                () =>
                    WritePi(cancellationTokenSource.Token),
                        TaskCreationOptions.LongRunning);

            // Wait for the user's input
            Console.ReadLine();

            cancellationTokenSource.Cancel();
            Console.WriteLine(stars);
            task.Wait();
            Console.WriteLine();
        }

        private static void WritePi(
            CancellationToken cancellationToken)
        {
            const int batchSize = 1;
            string piSection = string.Empty;
            int i = 0;

            while(!cancellationToken.IsCancellationRequested
                || i == int.MaxValue)
            {
                piSection = PiCalculator.Calculate(
                    batchSize, (i++) * batchSize);
                Console.Write(piSection);
            }
        }
    }
}

