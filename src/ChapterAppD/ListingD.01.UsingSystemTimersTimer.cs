namespace AddisonWesley.Michaelis.EssentialCSharp.AppendixD.ListingD_01
{
    using System;
    using System.Threading;
    using System.Timers;
    // Because Timer exists in both the System.Timers and
    // System.Threading namespaces, you disambiguate "Timer" 
    // using an alias directive.
    using Timer = System.Timers.Timer;

    class UsingSystemTimersTimer
    {
        private static int _Count = 0;
        private static readonly ManualResetEvent _ResetEvent =
           new ManualResetEvent(false);
        private static int _AlarmThreadId;

        public static void Main()
        {
            using (Timer timer = new Timer())
            {
                // Initialize Timer
                timer.AutoReset = true;
                timer.Interval = 1000;
                timer.Elapsed += new ElapsedEventHandler(Alarm);

                timer.Start();

                // Wait for Alarm to fire for the 10th time.
                _ResetEvent.WaitOne();
            }

            // Verify that the thread executing the alarm
            // Is different from the thread executing Main
            if (_AlarmThreadId ==
                Thread.CurrentThread.ManagedThreadId)
            {
                throw new ApplicationException(
                    "Thread Ids are the same.");
            }
            if (_Count < 9)
            {
                throw new ApplicationException(" _Count < 9");
            };

            Console.WriteLine(
                "(Alarm Thread Id) {0} != {1} (Main Thread Id)",
                _AlarmThreadId,
                Thread.CurrentThread.ManagedThreadId);
            Console.WriteLine("Final Count = {0}", _Count);
        }

        static void Alarm(object sender, ElapsedEventArgs eventArgs)
        {
            _Count++;

            Console.WriteLine("{0}:- {1}",
                eventArgs.SignalTime.ToString("T"),
                _Count);

            if (_Count >= 9)
            {
                _AlarmThreadId =
                    Thread.CurrentThread.ManagedThreadId;
                _ResetEvent.Set();
            }
        }
    }
}
