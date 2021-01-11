namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter17.Listing17_01
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        public static void Main()
        {
            List<string> list = new List<string>
            { "Sneezy", "Happy", "Dopey",  "Doc", "Sleepy", "Bashful",  "Grumpy"};

            list.Sort();

            Console.WriteLine(
                $"In alphabetical order { list[0] } is the "
                + $"first dwarf while { list[^1] } is the last.");

            list.Remove("Grumpy");
        }
    }
}
