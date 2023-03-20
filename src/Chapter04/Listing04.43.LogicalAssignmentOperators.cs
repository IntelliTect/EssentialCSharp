namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter04.Listing04_43;

public class Program
{
    public static void Main()
    {
        #region INCLUDE
        byte and = 12, or = 12, xor = 12;
        #region HIGHLIGHT
        and &= 7;   // and = 4
        or |= 7;   // or = 15
        xor ^= 7;   // xor = 11
        #endregion HIGHLIGHT
        Console.WriteLine( $"""
                and = {and}
                or = {or}
                xor = {xor}
                """);
        #endregion INCLUDE
    }
}
