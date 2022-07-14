namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter04.Listing04_42
{
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
            System.Console.WriteLine(
                $"and = { and } \nor = { or } \nxor = { xor }");
            #endregion INCLUDE
        }
    }
}
