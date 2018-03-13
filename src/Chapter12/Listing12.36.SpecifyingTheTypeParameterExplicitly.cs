namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter11.Listing11_36
{
    using System;
    using Listing11_35;

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