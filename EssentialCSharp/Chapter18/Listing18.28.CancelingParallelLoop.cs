namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter18.Listing18_28
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.IO;
    using System.Threading;
    using System.Threading.Tasks;

    public class Program
    {
        // ...

        static void EncryptFiles(
            string directoryPath, string searchPattern)
        {

            string stars =
                "*".PadRight(Console.WindowWidth - 1, '*');

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

            // Use Task.Factory.StartNew<string>() for
            // TPL prior to .NET 4.5
            Task task = Task.Run(() =>
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
            // ...
            throw new NotImplementedException();
        }
    }
}


