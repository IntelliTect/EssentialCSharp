namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter21.Listing21_01;

#region INCLUDE
using System;
using AddisonWesley.Michaelis.EssentialCSharp.Shared;

public class Program
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
#region EXCLUDE
/*
#endregion EXCLUDE
using System;

public static class PiCalculator
{
    public static string Calculate(
        int digits, int startingAt)
    {
        //...
    }

    //...
}
#region EXCLUDE
*/
#endregion EXCLUDE
#endregion INCLUDE
