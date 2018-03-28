namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter19.Listing19_02
{
    using System;
    using System.Threading;

    public class Program
    {
        public const int Repetitions = 1000;
        public static void Main()
        {
            ThreadPool.QueueUserWorkItem(DoWork, '+');

            for(int count = 0; count < Repetitions; count++)
            {
                Console.Write('-');
            }

            // Pause until the thread completes.
            // This is for illustrative purposes; do not
            // use Thread.Sleep for synchronization in 
            // production code.
            Thread.Sleep(1000);
        }
        public static void DoWork(object state)
        {
            for(int count = 0; count < Repetitions; count++)
            {
                Console.Write(state);
            }
        }
    }
}