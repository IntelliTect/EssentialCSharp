namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter09.Listing09_05
{
    using System;
    using System.Collections.Generic;

    public class DisplayFibonacci
    {
        static void Main()
        {
            int totalCount;
            List<double> list = new List<double>();

            Console.Write("Enter a number between 2 and 1000:");
            totalCount = int.Parse(Console.ReadLine());

            // Execution-time error:
            // list.Add(0);  // Cast to double or 'D' suffix required
                             // Whether cast or using 'D' suffix,
                             // CIL is identical
            list.Add((double)0);
            list.Add((double)1);
            for(int count = 2; count < totalCount; count++)
            {
                list.Add(
                    ((double)list[count - 1] +
                    (double)list[count - 2]));
            }

            foreach(double count in list)
            {
                Console.Write("{0}, ", count);
            }
        }
    }
}
