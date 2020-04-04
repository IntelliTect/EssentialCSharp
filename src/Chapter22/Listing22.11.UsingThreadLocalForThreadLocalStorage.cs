namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter22.Listing22_11
{
    using System;
    using System.Threading;

    class Program
    {
        static ThreadLocal<double> _Count =
            new ThreadLocal<double>(() => 0.01134);
        public static double Count
        {
            get { return _Count.Value; }
            set { _Count.Value = value; }
        }

        public static void Main()
        {
            Thread thread = new Thread(Decrement);
            thread.Start();

            // Increment
            for(double i = 0; i < short.MaxValue; i++)
            {
                Count++;
            }
            thread.Join();
            Console.WriteLine("Main Count = {0}", Count);
        }

        static void Decrement()
        {
            Count = -Count;
            for(double i = 0; i < short.MaxValue; i++)
            {
                Count--;
            }
            Console.WriteLine(
                "Decrement Count = {0}", Count);
        }
    }
}
