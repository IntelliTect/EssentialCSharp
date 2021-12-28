namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter22.Listing22_01
{
    using System;
    using System.Threading.Tasks;

    public class Program
    {
        static int _Total = int.MaxValue;
        static long _Count = 0;

        public static void Main()
        {
            // Use Task.Factory.StartNew for .NET 4.0
            Task task = Task.Run(() => Decrement());

            // Increment
            for(int i = 0; (i < _Total); i++)
            {
                _Count++;
            }

            task.Wait();
            Console.WriteLine($"Count = {_Count}");
        }

        static void Decrement()
        {
            // Decrement
            for(int i = 0; i < _Total; i++)
            {
                _Count--;
            }
        }
    }
}
