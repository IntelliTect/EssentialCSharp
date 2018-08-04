namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter12.Listing12_36
{
    using System;
    using Listing12_35;

    public class Program
    {
        public static void Main()
        {
            Console.WriteLine(
                MathEx.Max<int>(7, 490));
            Console.WriteLine(
                MathEx.Min<string>("R.O.U.S.", "Fireswamp"));
        }
    }
}
