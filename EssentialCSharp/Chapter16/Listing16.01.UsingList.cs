namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter16.Listing16_01
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        public static void Main()
        {
            List<string> list = new List<string>();

            // Lists automatically expand as elements
            // are added.
            list.Add("Sneezy");
            list.Add("Happy");
            list.Add("Dopey");
            list.Add("Doc");
            list.Add("Sleepy");
            list.Add("Bashful");
            list.Add("Grumpy");

            list.Sort();

            Console.WriteLine(
                "In alphabetical order {0} is the "
                + "first dwarf while {1} is the last.",
                list[0], list[6]);

            list.Remove("Grumpy");
        }
    }
}
