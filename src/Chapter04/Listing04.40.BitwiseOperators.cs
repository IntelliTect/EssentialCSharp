namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter04.Listing04_40
{
    public class Program
    {
        public static void Main()
        {
            byte and, or, xor;
            and = 12 & 7;   // and = 4
            or = 12 | 7;    // or = 15
            xor = 12 ^ 7;   // xor = 11
            System.Console.WriteLine(
                $"and = { and } \nor = { or }\nxor = { xor }");
        }
    }
}
