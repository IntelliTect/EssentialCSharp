namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter16.Listing16_08
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.IO;

    public class Program
    {
        public static void Main()
        {
            ListByFileSize2(Directory.GetCurrentDirectory(), "*");
        }

        static void ListByFileSize2(
            string rootDirectory, string searchPattern)
        {
            IEnumerable<FileInfo> files =
                from fileName in Directory.EnumerateFiles(
                    rootDirectory, searchPattern)
                orderby new FileInfo(fileName).Length, fileName
                select new FileInfo(fileName);

            foreach(FileInfo file in files)
            {
                //  As a simplification, the current directory 
                //  is assumed to be a subdirectory of
                //  rootDirectory
                string relativePath = file.FullName.Substring(
                    Directory.GetCurrentDirectory().Length);
                Console.WriteLine(
                    $".{ relativePath }({ file.Length })");
            }
        }
    }
}
