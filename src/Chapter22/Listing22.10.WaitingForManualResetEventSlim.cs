namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter22.Listing22_10
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;

    public class Program
    {
        // Justification: Initialized at the start of Main.
        #pragma warning disable CS8618 // Non-nullable field is uninitialized. Consider declaring as nullable.
        static ManualResetEventSlim MainSignaledResetEvent;
        static ManualResetEventSlim DoWorkSignaledResetEvent;
        #pragma warning restore CS8618 // Non-nullable field is uninitialized. Consider declaring as nullable.

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
