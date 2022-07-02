namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter21.Listing21_01
{
    using AddisonWesley.Michaelis.EssentialCSharp.Shared;
    using System;

    class Program
    {
        const int TotalDigits = 100;
        const int BatchSize = 10;

        public static void Main()
        {
            string pi = "";
            const int iterations = TotalDigits / BatchSize;
            for (int i = 0; i < iterations; i++)
            {
                pi += PiCalculator.Calculate(
                    BatchSize, i * BatchSize);
            }

            Console.WriteLine(pi);
        }
    }
}





