namespace AddisonWesley.Michaelis.EssentialCSharp.Shared.Listing18_19
{
    using System;
    using System.Threading;

    public class Program
    {
        public const int Repetitions = 1000;
        public static void Main()
        {
            ThreadPool.QueueUserWorkItem(DoWork, '.');

            for (int count = 0; count < Repetitions; count++)
            {
                Console.Write('-');
            }

            // Pause until the thread completes
            Thread.Sleep(1000);
        }
        public static void DoWork(object state)
        {
            for (int count = 0; count < Repetitions; count++)
            {
                Console.Write(state);
            }
        }
    }
}

