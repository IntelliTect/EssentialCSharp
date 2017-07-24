namespace AddisonWesley.Michaelis.EssentialCSharp.Shared.Listing18_08
{
    using System;

    class Program
    {
        const int TotalDigits = 100;
        const int BatchSize = 10;

        public static void Main()
        {
          string pi = null;
          int iterations = TotalDigits / BatchSize;
          for (int i = 0; i < iterations; i++)
          {
              pi += PiCalculator.Calculate(
                  BatchSize, i * BatchSize);
          }

          Console.WriteLine(pi);
        }
    }
}