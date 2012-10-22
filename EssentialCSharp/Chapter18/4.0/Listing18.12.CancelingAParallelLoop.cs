namespace AddisonWesley.Michaelis.EssentialCSharp.Shared.Listing18_12
{
    using System;
    using System.Diagnostics;
    using System.Threading;
    using System.Threading.Tasks;
    using System.Collections.Generic;
    using System.IO;

    public class Program
    {
        static void EncryptFiles(
            string directoryPath, string searchPattern)
        {
            string stars = "*".PadRight(Console.WindowWidth - 1, '*');
            
            IEnumerable<string> files = Directory.GetFiles(
               directoryPath, searchPattern,
               SearchOption.AllDirectories);

            CancellationTokenSource cts =
                new CancellationTokenSource();
            ParallelOptions parallelOptions =
                new ParallelOptions { CancellationToken = cts.Token };
            cts.Token.Register(
                () => Console.WriteLine("Cancelling..."));

            Console.WriteLine("Push ENTER to exit.");

            Task task = Task.Factory.StartNew(() =>
            {
                try
                {
                    Parallel.ForEach(
                        files, parallelOptions,
                        (fileName, loopState) =>
                        {
                            Encrypt(fileName);
                        });
                }
                catch (OperationCanceledException) { }
            });

            // Wait for the user's input
            Console.Read();

            // Cancel the query
            cts.Cancel();
            Console.Write(stars);
            task.Wait();
        }

        private static void Encrypt(string fileName)
        {
            int oneSecond = 1000;

            Console.WriteLine(string.Format("-----Pretending to encrypt '{0}'.", fileName));
            Thread.Sleep(oneSecond);
            Console.WriteLine(string.Format("|||||Finished 'encrypting' '{0}'.", fileName));
        }

        public static void Main()
        {
            EncryptFiles(Directory.GetCurrentDirectory(), "*");
            Console.WriteLine();
        }
    }
}
