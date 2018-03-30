namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter20.Listing20_10
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;

    public class Program
    {
        static ManualResetEventSlim MainSignaledResetEvent;
        static ManualResetEventSlim DoWorkSignaledResetEvent;

        public static void DoWork()
        {
            Console.WriteLine("DoWork() started....");
            DoWorkSignaledResetEvent.Set();
            MainSignaledResetEvent.Wait();
            Console.WriteLine("DoWork() ending....");
        }

        public static void Main()
        {
            using(MainSignaledResetEvent =
                new ManualResetEventSlim())
            using(DoWorkSignaledResetEvent =
                new ManualResetEventSlim())
            {
                Console.WriteLine(
                    "Application started....");
                Console.WriteLine("Starting task....");

                // Use Task.Factory.StartNew for .NET 4.0
                Task task = Task.Run(() => DoWork());

                // Block until DoWork() has started
                DoWorkSignaledResetEvent.Wait();
                Console.WriteLine(
                    " Waiting while thread executes...");
                MainSignaledResetEvent.Set();
                task.Wait();
                Console.WriteLine("Thread completed");
                Console.WriteLine(
                    "Application shutting down....");
            }
        }
    }
}
