namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter14.Listing14_16
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    public class Program
    {
        public static void ChapterMain()
        {
            string rootDirectory = Directory.GetCurrentDirectory();
            string searchPattern = "*";

            IEnumerable<string> fileList = Directory.EnumerateFiles(
                rootDirectory, searchPattern);
            IEnumerable<(string FileName, long Size)> items = fileList.Select(
                file =>
                {
                    FileInfo fileInfo = new FileInfo(file);
                    return (
                        FileName: fileInfo.Name,
                        Size: fileInfo.Length
                    );
                });



            Print(items);
        }

        private static void Print(IEnumerable<(string FileName, long Size)> items)
        {
            foreach((string FileName, long Size) item in items)
            {
                Console.WriteLine($"FileName = { item.FileName }, Size = { item.Size }");
            }
        }
    }
}
