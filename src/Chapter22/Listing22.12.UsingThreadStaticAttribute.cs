namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter22.Listing22_12
{
    using System;
    using System.Threading;

    class Program
    {
        [ThreadStatic]
        static double _Count = 0.01134;
        public static double Count
        {
            get { return Program._Count; }
            set { Program._Count = value; }
        }

        public static void Main()
        {
            Thread thread = new Thread(Decrement);
            thread.Start();

            // Increment
            for(int i = 0; i < short.MaxValue; i++)
            {
                Count++;
            }

            thread.Join();
            Console.WriteLine("Main Count = {0}", Count);
        }

        static void Decrement()
        {
            for(int i = 0; i < short.MaxValue; i++)
            {
                Count--;
            }
            Console.WriteLine("Decrement Count = {0}", Count);
        }
    }
}
