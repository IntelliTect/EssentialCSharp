namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter22.Listing22_05
{
    using System;
    using System.Threading.Tasks;

    public class Program
    {
        readonly static object _Sync = new object();
        static int _Total = int.MaxValue;
        static long _Count = 0;

        public static async Task Main()
        {
            // Use Task.Factory.StartNew for .NET 4.0
            Task task = Task.Run(() => Decrement());

            // Increment
            for(int i = 0; i < _Total; i++)
            {
                lock(_Sync)
                {
                    _Count++;
                }
            }

            await task;
            Console.WriteLine($"Count = {_Count}");
        }

        static void Decrement()
        {
            for(int i = 0; i < _Total; i++)
            {
                lock(_Sync)
                {
                    _Count--;
                }
            }
        }
    }
}
