namespace AddisonWesley.Michaelis.EssentialCSharp.AppendixD.ListingD_02
{
    using System;
    using System.Threading;

    class UsingSystemThreadingTimer
    {
        private static int _Count = 0;
        private static readonly AutoResetEvent _ResetEvent =
            new AutoResetEvent(false);
        private static int _AlarmThreadId;

        public static void Main()
        {
            // Timer(callback, state, dueTime, period)
            using(Timer timer = new Timer(Alarm, null, 0, 1000))
            {
                // Wait for Alarm to fire for the 10th time.
                _ResetEvent.WaitOne();
            }

            // Verify that the thread executing the alarm
            // Is different from the thread executing Main
            if(_AlarmThreadId ==
                Thread.CurrentThread.ManagedThreadId)
            {
                throw new ApplicationException(
                    "Thread Ids are the same.");
            }
            if(_Count < 9)
            {
                throw new ApplicationException(" _Count < 9");
            };

            Console.WriteLine(
                "(Alarm Thread Id) {0} != {1} (Main Thread Id)",
                _AlarmThreadId,
                Thread.CurrentThread.ManagedThreadId);
            Console.WriteLine("Final Count = {0}", _Count);
        }

        static void Alarm(object state)
        {
            _Count++;

            Console.WriteLine("{0}:- {1}",
                DateTime.Now.ToString("T"),
                _Count);

            if(_Count >= 9)
            {
                _AlarmThreadId =
                    Thread.CurrentThread.ManagedThreadId;
                _ResetEvent.Set();
            }
        }
    }
}
