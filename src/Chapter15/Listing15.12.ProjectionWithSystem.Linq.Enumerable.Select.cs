namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter15.Listing15_12
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            string rootDirectory = Directory.GetCurrentDirectory();
            string searchPattern = "*"; ;

            IEnumerable<string> fileList = Directory.EnumerateFiles(
                rootDirectory, searchPattern);
            IEnumerable<FileInfo> files = fileList.Select(
                file => new FileInfo(file));

            Print(files);
        }

        private static void Print<T>(IEnumerable<T> items)
        {
            foreach (T item in items)
            {
                Console.WriteLine(item);
            }
        }
    }
}
