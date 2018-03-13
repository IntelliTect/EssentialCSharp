namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter11.Listing11_37
{
    using System;
    using Listing11_35;

    public class Program
    {
        public static void Main()
        {
            Console.WriteLine(
                MathEx.Max(7, 490)); // No type arguments!
            Console.WriteLine(
                MathEx.Min("R.O.U.S'", "Fireswamp"));
        }
    }
}