namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter15.Listing15_14
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
            foreach(T item in items)
            {
                Console.WriteLine(item);
            }
        }
    }
}
