namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter19.Listing19_01
{
    using System;
    using System.Threading;

    public class RunningASeparateThread
    {
        public const int Repetitions = 1000;

        public static void Main()
        {
            ThreadStart threadStart = DoWork;
            Thread thread = new Thread(threadStart);
            thread.Start();
            for(int count = 0; count < Repetitions; count++)
            {
                Console.Write('-');
            }
            thread.Join();
        }

        public static void DoWork()
        {
            for(int count = 0; count < Repetitions; count++)
            {
                Console.Write('+');
            }
        }
    }
}