namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter16.Listing16_07
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.IO;

    public class Program
    {
        public static void Main()
        {
            ListByFileSize1(Directory.GetCurrentDirectory(), "*");
        }

        static void ListByFileSize1(
            string rootDirectory, string searchPattern)
        {
            IEnumerable<string> fileNames =
                from fileName in Directory.EnumerateFiles(
                    rootDirectory, searchPattern)
                orderby (new FileInfo(fileName)).Length descending,
                    fileName
                select fileName;

            foreach(string fileName in fileNames)
            {
                Console.WriteLine(fileName);
            }
        }
    }
}
