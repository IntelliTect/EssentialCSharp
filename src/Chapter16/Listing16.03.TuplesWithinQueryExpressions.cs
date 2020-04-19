namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter16.Listing16_03
{
    using System;
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
                select
                (
                    Name: fileName,
                    LastWriteTime: File.GetLastWriteTime(fileName)
                );

            foreach (var fileResult in fileResults)
            {
                Console.WriteLine(
                    $@"{ fileResult.Name } ({ 
                        fileResult.LastWriteTime })");
            }
        }
    }
}