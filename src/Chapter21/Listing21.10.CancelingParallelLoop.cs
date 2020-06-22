namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter21.Listing21_10
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading;
    using System.Threading.Tasks;
    using AddisonWesley.Michaelis.EssentialCSharp.Shared;

    public static class Program
    {
        public static List<string> ParallelEncrypt(
            List<string> data,
            CancellationToken cancellationToken)
        {
            int govener = 0;
            return data.AsParallel().WithCancellation(
                cancellationToken).Select(
                    (item) =>
                    {
                        if (Interlocked.CompareExchange(
                            ref govener, 0, 100) % 100 == 0)
                        {
                            Console.Write('.');
                        }
                        Interlocked.Increment(ref govener);
                        return Encrypt(item);
                    }).ToList();
        }

        public static async Task Main()
        {
            ConsoleColor originalColor = Console.ForegroundColor;
            List<string> data = Utility.GetData(100000).ToList();

            using CancellationTokenSource cts =
                new CancellationTokenSource();

            Task task = Task.Run(() =>
            {
                data = ParallelEncrypt(data, cts.Token);
            }, cts.Token);

            Console.WriteLine("Press any key to Exit.");
            Task<int> cancelTask = ConsoleReadAsync(cts.Token);

            try
            {
                Task.WaitAny(task, cancelTask);
                // Cancel whichever task has not finished.
                cts.Cancel();
                await task;

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nCompleted successfully");

            }
            catch (OperationCanceledException taskCanceledException)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(
                    $"\nCancelled: { taskCanceledException.Message }");
            }
            finally
            {
                Console.ForegroundColor = originalColor;
            }
        }

        private static async Task<int> ConsoleReadAsync(
            CancellationToken cancellationToken = default)
        {
            return await Task.Run(async () =>
            {
                const int maxDelay = 1025;
                int delay = 0;
                while (!cancellationToken.IsCancellationRequested)
                {
                    if (Console.KeyAvailable)
                    {
                        return Console.Read();
                    }
                    else
                    {
                        await Task.Delay(delay, cancellationToken);
                        if (delay < maxDelay) delay *= 2 + 1;
                    }
                }
                cancellationToken.ThrowIfCancellationRequested();
                throw new InvalidOperationException(
                    "Previous line should throw preventing this from ever executing");
            }, cancellationToken);
        }

        private static string Encrypt(string item)
        {
            Cryptographer cryptographer = new Cryptographer();
            return System.Text.Encoding.UTF8.GetString(cryptographer.Encrypt(item));
        }

        // ...
    }

}


