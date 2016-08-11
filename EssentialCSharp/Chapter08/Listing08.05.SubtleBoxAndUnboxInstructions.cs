namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter08.Listing08_05
{
    using System;

    public class DisplayFibonacci
    {
        static void ChapterMain()
        {
            int totalCount;
            System.Collections.ArrayList list =
                new System.Collections.ArrayList();

            Console.Write("Enter a number between 2 and 1000:");
            totalCount = int.Parse(Console.ReadLine());

            // Execution-time error:
            // list.Add(0);  // Cast to double or 'D' suffix required.
                             // Whether cast or using 'D' suffix,
                             // CIL is identical.
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
