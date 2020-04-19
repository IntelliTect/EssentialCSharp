namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter19.Listing19_09
{
    using System;
    using System.Diagnostics;
    using System.Threading;

    public class Program
    {
        public static Stopwatch clock = new Stopwatch();
        public static void Main()
        {
            ManualResetEventSlim resetEvent = new ManualResetEventSlim();
            try
            {
                clock.Start();

                // Register a callback to receive notifications
                // of any unhandled exception
#if NETCOREAPP1_1
                System.Threading.Tasks.TaskScheduler.UnobservedTaskException += (s, e) =>
                {
                    Message("Event handler starting");
                    resetEvent.Set();
                };

                void Work()
                {
                    Task task = Task.Factory.StartNew(() =>
                    {
                        Message("Throwing exception.");
                        throw new Exception();
                    });
                }
                Work();

                Task.Delay(5000);
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();


#else
                Action<object, EventArgs> unhandledExcpetionHandler = (s, e) =>
                {
                    Message("Event handler starting");
                    Delay(4000);
                };
                AppDomain.CurrentDomain.UnhandledException +=
                  (s, e) =>
                  {
                      Message("Event handler starting");
                      Delay(4000);
                  };
                Thread thread = new Thread(() =>
                {
                    Message("Throwing exception.");
                    throw new Exception();
                });
                thread.Start();

#endif
#if DEBUG1   
                resetEvent.Wait();
                {
#else
                if (!resetEvent.Wait(5000))
                {
                    throw new Exception("Timed out waiting for unhandled exception.");
#endif // DEBUG
                }
                //Delay(2000)
            }
            finally
            {
                Message("Finally block running.");
            }
        }

        static void Delay(int i)
        {
            Message($"Sleeping for {i} ms");
            Thread.Sleep(i);
            Message("Awake");
        }

        static void Message(string text)
        {
            Console.WriteLine(
                $"{Thread.CurrentThread.ManagedThreadId}:{text}");
        }
    }
}
