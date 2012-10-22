namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter18.Listing18_09
{
    using System;
    using System.Diagnostics;
    using System.Threading;

    public class Program
    {
        public static Stopwatch clock = new Stopwatch();
        public static void Main()
        {
            try
            {
                clock.Start();
                // Register a callback to receive notifications
                // of any unhandled exception.
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

                Delay(2000);
            }
            finally
            {
                Message("Finally block running.");
            }
        }

        static void Delay(int i)
        {
            Message(string.Format("Sleeping for {0} ms", i));
            Thread.Sleep(i);
            Message("Awake");
        }

        static void Message(string text)
        {
            Console.WriteLine("{0}:{1:0000}:{2}",
              Thread.CurrentThread.ManagedThreadId,
                    clock.ElapsedMilliseconds,
              text);
        }
    }
}
