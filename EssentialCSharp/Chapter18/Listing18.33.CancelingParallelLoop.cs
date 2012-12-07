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
            return data.AsParallel().WithCancellation(
                cancellationToken).Select(
                    (item) => Encrypt(item)).ToList();
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
            Console.Read();

            cts.Cancel();
            try { task.Wait(); }
            catch(AggregateException) { }
        }

        private static string Encrypt(string item)
        {
            // ...
            throw new NotImplementedException();
        }

        // ...
    }

}


