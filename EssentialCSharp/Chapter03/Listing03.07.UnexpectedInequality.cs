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
            // Displays: 4.2 != 4.20000006258488 
            System.Console.WriteLine(
                "{0} != {1}", decimalNumber, (decimal)doubleNumber1);

            Trace.Assert((double)decimalNumber != doubleNumber1);
            // Displays: 4.2 != 4.20000006258488 
            System.Console.WriteLine(
                "{0} != {1}", (double)decimalNumber, doubleNumber1);

            Trace.Assert((float)decimalNumber != floatNumber);
            // Displays: (float)4.2M != 4.2F
            System.Console.WriteLine(
                "(float){0}M != {1}F",
                (float)decimalNumber, floatNumber);

            Trace.Assert(doubleNumber1 != (double)floatNumber);
            // Displays: 4.20000006258488 != 4.20000028610229 
            System.Console.WriteLine(
                "{0} != {1}", doubleNumber1, (double)floatNumber);

            Trace.Assert(doubleNumber1 != doubleNumber2);
            // Displays: 4.20000006258488 != 4.2
            System.Console.WriteLine(
                "{0} != {1}", doubleNumber1, doubleNumber2);

            Trace.Assert(floatNumber != doubleNumber2);
            // Displays: 4.2F != 4.2D
            System.Console.WriteLine(
                "{0}F != {1}D", floatNumber, doubleNumber2);

            Trace.Assert((double)4.2F != 4.2D);
            // Display: 4.19999980926514 != 4.2
            System.Console.WriteLine(
                "{0} != {1}", (double)4.2F, 4.2D);

            Trace.Assert(4.2F != 4.2D);
            // Display: 4.2F != 4.2D
            System.Console.WriteLine(
                "{0}F != {1}D", 4.2F, 4.2D);
        }
    }
}
