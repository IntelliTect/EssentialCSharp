namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter04.Listing04_42
{
    public class Program
    {
        public static void Main()
        {
            byte and = 12, or = 12, xor = 12;
            and &= 7;   // and = 4
            or |= 7;   // or = 15
            xor ^= 7;   // xor = 11
            System.Console.WriteLine(
                $"and = { and } \nor = { or }\nxor = { xor }");
        }
    }
}
