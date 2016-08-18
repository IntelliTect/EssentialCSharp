namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter14.Listing14_06
{
    using System;

    public class Program
    {
        public static void ChapterMain()
        {
            int[] array = new int[] { 1, 2, 3, 4, 5, 6 };

            foreach(int item in array)
            {
                Console.WriteLine(item);
            }
        }
    }
}