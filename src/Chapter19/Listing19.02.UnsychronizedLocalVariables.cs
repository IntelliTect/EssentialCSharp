namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter19.Listing19_02
{
    using System;
    using System.Threading.Tasks;

    class Program
    {
        public static void Main()
        {
            int x = 0;
            Parallel.For(0, int.MaxValue, i =>
            {
                x++;
                x--;
            });
            Console.WriteLine("Count = {0}", x);
        }
    }
}
