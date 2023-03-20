namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter04.Listing04_41;

public class Program
{
    public static void Main()
    {
        #region INCLUDE
        byte and, or, xor;
        and = 12 & 7;   // and = 4
        or = 12 | 7;    // or = 15
        xor = 12 ^ 7;   // xor = 11
        Console.WriteLine( $"""
                and = { and }
                or = { or }
                xor = { xor }
                """);
        #endregion INCLUDE
    }
}
