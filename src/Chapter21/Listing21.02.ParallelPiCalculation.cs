namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter21.Listing21_02;

#region INCLUDE
using System;
#region HIGHLIGHT
using System.Threading.Tasks;
#endregion HIGHLIGHT
using AddisonWesley.Michaelis.EssentialCSharp.Shared;

//...

public class Program
{
    const int TotalDigits = 100;
    const int BatchSize = 10;

    public static void Main()
    {
        string pi = "";
        const int iterations = TotalDigits / BatchSize;
        string[] sections = new string[iterations];
        #region HIGHLIGHT
        Parallel.For(0, iterations, i =>
        {
            sections[i] = PiCalculator.Calculate(
                BatchSize, i * BatchSize);
        });
        #endregion HIGHLIGHT

        pi = string.Join("", sections);
        Console.WriteLine(pi);
    }
}
#endregion INCLUDE
