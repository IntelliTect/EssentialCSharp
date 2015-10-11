using System.Diagnostics;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter03.Listing03_07
{
    public class Program
    {
        public static void Main()
        {
            decimal decimalNumber = 4.2M;
            double doubleNumber1 = 0.1F * 42F;
            double doubleNumber2 = 0.1D * 42D;
            float floatNumber = 0.1F * 42F;

            Trace.Assert(decimalNumber != (decimal)doubleNumber1);
            // 1. Displays: 4.2 != 4.20000006258488
            System.Console.WriteLine(
                $"{decimalNumber} != {(decimal)doubleNumber1}");

            Trace.Assert((double)decimalNumber != doubleNumber1);
            // 2. Displays: 4.2 != 4.20000006258488
            System.Console.WriteLine(
                $"{(double)decimalNumber} != {doubleNumber1}");

            Trace.Assert((float)decimalNumber != floatNumber);
            // 3. Displays: (float)4.2M != 4.2F
            System.Console.WriteLine(
                $"(float){(float)decimalNumber}M != {floatNumber}F");

            Trace.Assert(doubleNumber1 != (double)floatNumber);
            // 4. Displays: 4.20000006258488 != 4.20000028610229
            System.Console.WriteLine(
                $"{doubleNumber1} != {(double)floatNumber}");

            Trace.Assert(doubleNumber1 != doubleNumber2);
            // 5. Displays: 4.20000006258488 != 4.2
            System.Console.WriteLine(
                $"{doubleNumber1} != {doubleNumber2}");

            Trace.Assert(floatNumber != doubleNumber2);
            // 6. Displays: 4.2F != 4.2D
            System.Console.WriteLine(
                $"{floatNumber}F != {doubleNumber2}D");

            Trace.Assert((double)4.2F != 4.2D);
            // 7. Displays: 4.19999980926514 != 4.2
            System.Console.WriteLine(
                $"{(double)4.2F} != {4.2D}");

            Trace.Assert(4.2F != 4.2D);
            // 8. Displays: 4.2F != 4.2D
            System.Console.WriteLine(
                $"{4.2F}F != {4.2D}D");
        }
    }
}
