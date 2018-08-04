namespace AddisonWesley.Michaelis.EssentialCSharp.Shared.Listing18_06
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;

    public class Program
    {
        public static void Main()
        {
            string stars = "*".PadRight(Console.WindowWidth - 1, '*');
            Console.WriteLine("Push ENTER to exit.");

            CancellationTokenSource cancellationTokenSource =
                new CancellationTokenSource();
            Task task = Task.Factory.StartNew(
                () => WritePi(cancellationTokenSource.Token),
                cancellationTokenSource.Token);

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

            while (!cancellationToken.IsCancellationRequested
                || i == int.MaxValue)
            {
                piSection = PiCalculator.Calculate(
                    batchSize, (i++) * batchSize);
                Console.Write(piSection);
            }
        }
    }

}
