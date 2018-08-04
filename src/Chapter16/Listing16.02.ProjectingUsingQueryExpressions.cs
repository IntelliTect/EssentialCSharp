namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter16.Listing16_02
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            List1(Directory.GetCurrentDirectory(), "*");
        }

        static void List1(string rootDirectory, string searchPattern)
        {
            IEnumerable<string> fileNames = Directory.GetFiles(
                rootDirectory, searchPattern);

            IEnumerable<FileInfo> fileInfos =
                from fileName in fileNames
                select new FileInfo(fileName);

            foreach(FileInfo fileInfo in fileInfos)
            {
                Console.WriteLine(
                    $@".{ fileInfo.Name } ({
                        fileInfo.LastWriteTime })");
            }
        }
    }
}