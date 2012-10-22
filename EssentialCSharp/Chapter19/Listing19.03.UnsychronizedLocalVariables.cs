namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter19.Listing19_03
{
    using System;
    using System.Threading.Tasks;

    class Program
    {
        public static void Main()
        {
            CountAsync();
        }

        // ...

        public static async void CountAsync()
        {
            // Use Task.Factory.StartNew for .NET 4.0
            Task task = Task.Run(() => Decrement());

            // Increment
            for (int i = 0; i < _Total; i++)
            {
                _Count++;
            }

            await task;
            Console.WriteLine("Count = {0}", _Count);
        }

        private static Task Decrement()
        {
            throw new NotImplementedException();
        }

        public static int _Count { get; set; }

        public static int _Total { get; set; }
    }
}
