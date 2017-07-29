namespace AddisonWesley.Michaelis.EssentialCSharp.Shared.Listing18_18
{
    using System;
    using System.Threading;

    public class Program
    {
        public const int Repetitions = 1000;

        public static void Main()
        {
            ThreadStart threadStart = DoWork;
            Thread thread = new Thread(threadStart);
            thread.Start();
            for (int count = 0; count < Repetitions; count++)
            {
                Console.Write('-');
            }
            thread.Join();
        }

        public static void DoWork()
        {
            for (int count = 0; count < Repetitions; count++)
            {
                Console.Write('.');
            }
        }
    }
}

