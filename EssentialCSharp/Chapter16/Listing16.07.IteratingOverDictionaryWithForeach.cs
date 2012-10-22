namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter16.Listing16_07
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        public static void Main()
        {
            var dictionary = new Dictionary<string, string>();

            dictionary.Add("do", "a deer");
            dictionary.Add("re", "a drop");
            dictionary.Add("mi", "a name");
            dictionary.Add("fa", "a long way");
            dictionary.Add("so", "a needle");
            dictionary.Add("la", "a note");
            dictionary.Add("ti", "a drink");

            Console.WriteLine("Key  Value   ");
            Console.WriteLine("---  ------- ");

            foreach (KeyValuePair<string, string> i in dictionary)
            {
                Console.WriteLine("{0}   {1}", i.Key, i.Value);
            }
        }
    }
}