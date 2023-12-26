namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter04.Listing04_07;

public class Program
{
    public static void Main()
    {
        #region INCLUDE
        decimal decimalNumber = 4.2M;
        double doubleNumber1 = 0.1F * 42F;
        double doubleNumber2 = 0.1D * 42D;
        float floatNumber = 0.1F * 42F;

        // 1. 显示：4.2 != 4.2000002861023 - True
        Console.WriteLine($"{decimalNumber} != {(decimal)doubleNumber1} - {decimalNumber != (decimal)doubleNumber1}");

        // 2. 显示：4.2 != 4.200000286102295 - True
        Console.WriteLine($"{(double)decimalNumber} != {doubleNumber1} - {(double)decimalNumber != doubleNumber1}");

        // 3. 显示：(float)4.2M != 4.2000003F - True
        Console.WriteLine($"(float){(float)decimalNumber}M != {floatNumber}F - {(float)decimalNumber != floatNumber}");

        // 4. 显示：4.200000286102295 != 4.2 - True
        Console.WriteLine($"{doubleNumber1} != {doubleNumber2} - {doubleNumber1 != doubleNumber2}");

        // 5. 显示：4.2000003F != 4.2D - True
        Console.WriteLine($"{floatNumber}F != {doubleNumber2}D - {floatNumber != doubleNumber2}");

        // 6. 显示：4.199999809265137 != 4.2 - True
        Console.WriteLine($"{(double)4.2F} != {4.2D} - {(double)4.2F != 4.2D}");

        // 7. 显示：4.2F != 4.2D - True
        Console.WriteLine($"{4.2F}F != {4.2D}D - {4.2F != 4.2D}");
        #endregion INCLUDE
    }
}
