namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter19.Listing19_26
{
    using System;
    using AddisonWesley.Michaelis.EssentialCSharp.Shared;

    class Program
    {
        const int TotalDigits = 100;
        const int BatchSize = 10;

        public static void Main()
        {
            string pi = null;
            const int iterations = TotalDigits / BatchSize;
            for(int i = 0; i < iterations; i++)
            {
                pi += PiCalculator.Calculate(
                    BatchSize, i * BatchSize);
            }

            Console.WriteLine(pi);
        }
    }
}





