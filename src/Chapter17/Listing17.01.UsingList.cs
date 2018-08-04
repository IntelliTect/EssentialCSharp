namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter17.Listing17_01
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        public static void Main()
        {
            List<string> list = new List<string>();

            // Lists automatically expand as elements
            // are added
            list.Add("Sneezy");
            list.Add("Happy");
            list.Add("Dopey");
            list.Add("Doc");
            list.Add("Sleepy");
            list.Add("Bashful");
            list.Add("Grumpy");

            list.Sort();

            Console.WriteLine(
                $"In alphabetical order { list[0] } is the "
                + $"first dwarf while { list[6] } is the last.");


            list.Remove("Grumpy");
        }
    }
}
