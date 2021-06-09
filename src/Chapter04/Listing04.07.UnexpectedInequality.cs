namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter04.Listing04_07
{
    public class Program
    {
        public static void Main()
        {
            decimal decimalNumber = 4.2M;
            double doubleNumber1 = 0.1F * 42F;
            double doubleNumber2 = 0.1D * 42D;
            float floatNumber = 0.1F * 42F;

            
            // 1. Displays: 4.2 != 4.4.2000002861023
            System.Console.WriteLine(
                $"{decimalNumber} != {(decimal)doubleNumber1}");

            // 2. Displays: 4.2 != 4.200000286102295
            System.Console.WriteLine(
                $"{(double)decimalNumber} != {doubleNumber1}");

            // 3. Displays: (float)4.2M != 4.2000003F
            System.Console.WriteLine(
                $"(float){(float)decimalNumber}M != {floatNumber}F");

            // 4. Displays: 4.200000286102295 != 4.2
            System.Console.WriteLine(
                $"{doubleNumber1} != {doubleNumber2}");

            // 5. Displays: 4.2000003F != 4.2D
            System.Console.WriteLine(
                $"{floatNumber}F != {doubleNumber2}D");

            // 6. Displays: 4.199999809265137 != 4.2
            System.Console.WriteLine(
                $"{(double)4.2F} != {4.2D}");

            // 7. Displays: 4.2F != 4.2D
            System.Console.WriteLine(
                $"{4.2F}F != {4.2D}D");
        }
    }
}
