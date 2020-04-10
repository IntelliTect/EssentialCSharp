namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter21.Listing21_02
{
    using System;
    using System.Threading.Tasks;
    using AddisonWesley.Michaelis.EssentialCSharp.Shared;

    class Program
    {
        const int TotalDigits = 100;
        const int BatchSize = 10;

        public static void Main()
        {
            string pi = "";
            const int iterations = TotalDigits / BatchSize;
            string[] sections = new string[iterations];
            Parallel.For(0, iterations, i =>
            {
                sections[i] = PiCalculator.Calculate(
                    BatchSize, i * BatchSize);
            });

            pi = string.Join("", sections);
            Console.WriteLine(pi);
        }
    }
}





