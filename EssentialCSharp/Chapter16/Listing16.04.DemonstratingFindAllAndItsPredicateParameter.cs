namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter16.Listing16_04
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        public static void Main()
        {
            List<int> list = new List<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(2);

            List<int> results = list.FindAll(Even);

            foreach (int number in results)
            {
                Console.WriteLine(number);
            }
        }

        public static bool Even(int value)
        {
            return (value % 2) == 0;
        }
    }

}
