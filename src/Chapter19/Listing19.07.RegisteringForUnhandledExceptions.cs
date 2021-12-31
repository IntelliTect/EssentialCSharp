namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter19.Listing19_07
{
    using System;
    using System.Diagnostics;
    using System.Threading;

    public class Program
    {
        private static Stopwatch Clock { get;  } = new Stopwatch();

        public static void Main()
        {
            try
            {
                Clock.Start();
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

                Action<object, EventArgs> unhandledExcpetionHandler = (s, e) =>
                {
                    Message("Event handler starting");
                    Delay(4000);
                };
#else
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
                if (!resetEvent.Wait(5000))
                {
                    throw new Exception("Timed out waiting for unhandled exception.");
                }
#endif // DEBUG
                Delay(2000);
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
            Console.WriteLine("{0}:{1:0000}:{2}",
                Thread.CurrentThread.ManagedThreadId,
                Clock.ElapsedMilliseconds, text);
        }
    }
}
