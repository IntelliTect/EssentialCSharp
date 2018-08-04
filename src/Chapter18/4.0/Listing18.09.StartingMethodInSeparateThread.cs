namespace AddisonWesley.Michaelis.EssentialCSharp.Shared.Listing18_09
{
    using System;
    using System.Threading.Tasks;


    class Program
    {
        const int TotalDigits = 100;
        const int BatchSize = 10;

        public static void Main()
        {
            string pi = null;
            int iterations = TotalDigits / BatchSize;
            string[] sections = new string[iterations];
            Parallel.For(0, iterations, (i) =>
            {
                sections[i] += PiCalculator.Calculate(
                    BatchSize, i * BatchSize);
            });
            pi = string.Join("", sections);
            Console.WriteLine(pi);

        }
    }
}