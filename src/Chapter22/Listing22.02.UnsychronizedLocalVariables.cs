namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter22.Listing22_02
{
    using System;
    using System.Threading.Tasks;

    public class Program
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
