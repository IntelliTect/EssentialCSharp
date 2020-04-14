namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter15.Listing15_16
{
    using AddisonWesley.Michaelis.EssentialCSharp.Chapter15.Listing15;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            IEnumerable<Patent> patents = PatentData.Patents;
            bool result;
            patents = patents.Where(
                patent =>
                {
                    if(result =
                        patent.YearOfPublication.StartsWith("18"))
                    {
                        // Side effects like this in a predicate
                        // are used here to demonstrate a 
                        // principle and should generally be
                        // avoided
                        Console.WriteLine("\t" + patent);
                    }
                    return result;
                });

            Console.WriteLine("1. Patents prior to the 1900s are:");
            foreach(Patent patent in patents)
            {
            }

            Console.WriteLine();
            Console.WriteLine(
                "2. A second listing of patents prior to the 1900s:");
            Console.WriteLine(
                $@"   There are { patents.Count()
                    } patents prior to 1900.");


            Console.WriteLine();
            Console.WriteLine(
                "3. A third listing of patents prior to the 1900s:");
            patents = patents.ToArray();
            Console.Write("   There are ");
            Console.WriteLine(
                $"{ patents.Count() } patents prior to 1900.");
        }
    }
}
