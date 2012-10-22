namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter14.Listing14_16
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.IO;

    public class Program
    {
        public static void Main()
        {
            string rootDirectory = Directory.GetCurrentDirectory();
            string searchPattern = "*";

            IEnumerable<string> fileList = Directory.GetFiles(
                rootDirectory, searchPattern);
            var items = fileList.AsParallel().Select(
                file =>
                {
                    FileInfo fileInfo = new FileInfo(file);
                    return new
                    {
                        FileName = fileInfo.Name,
                        Size = fileInfo.Length
                    };
                });

            Print(items);
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