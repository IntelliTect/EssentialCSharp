namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter16.Listing16_03A
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            List2(Directory.GetCurrentDirectory(), "*");
        }

        static void List2(string rootDirectory, string searchPattern)
        {
            var fileNames = Directory.EnumerateFiles(
                rootDirectory, searchPattern);
            var fileResults =
                from fileName in fileNames
                select new
                {
                    Name = fileName,
                    LastWriteTime = File.GetLastWriteTime(fileName)
                };

            foreach(var fileResult in fileResults)
            {
                Console.WriteLine(
                    $@"{ fileResult.Name } ({ 
                        fileResult.LastWriteTime })");
            }
        }
    }
}