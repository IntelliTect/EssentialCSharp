namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter18.Listing18_33
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading;
    using System.Threading.Tasks;
    using AddisonWesley.Michaelis.EssentialCSharp.Shared;

    public class Program
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
                        if (Interlocked.CompareExchange(ref govener, 0, 100)%100 == 0)
                        {
                            Console.Write('.');
                        }
                        Interlocked.Increment(ref govener);
                        return Encrypt(item);
                    }).ToList();
        }

        public static void Main()
        {
            List<string> data = Utility.GetData(1000000).ToList();

            CancellationTokenSource cts =
                new CancellationTokenSource();

            Console.WriteLine("Push ENTER to exit.");

            // Use Task.Factory.StartNew<string>() for
            // TPL prior to .NET 4.5
            Task task = Task.Run(() =>
            {
                data = ParallelEncrypt(data, cts.Token);
            }, cts.Token);

            // Wait for the user's input
            char character = (char)Console.Read();

            if (char.ToLower(character) == '\r')
            {
                cts.Cancel();
                Console.WriteLine("Cancelled");
            }
            try { task.Wait(); }
            catch(AggregateException exception)
            {
                string message = string.Join(Environment.NewLine, exception.Flatten().InnerExceptions.Select(
                    eachException => $"\t{ eachException.Message }").Distinct());
                Console.WriteLine($"ERROR(s): { Environment.NewLine }{ message }");
            }
        }

        private static string Encrypt(string item)
        {
            Cryptographer cryptographer = new Cryptographer();
            return cryptographer.Encrypt(item);
        }

        // ...
    }

}


