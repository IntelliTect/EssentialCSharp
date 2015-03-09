namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter15.Listing15_08
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
                from fileName in Directory.GetFiles(
                    rootDirectory, searchPattern)
                orderby new FileInfo(fileName).Length, fileName
                select new FileInfo(fileName);

            foreach(FileInfo file in files)
            {
                //  As simplification, current directory is
                //  assumed to be a subdirectory of
                //  rootDirectory
                string relativePath = file.FullName.Substring(
                    Environment.CurrentDirectory.Length);
                Console.WriteLine(
                    $".{ relativePath }({ file.Length })");
            }
        }
    }
}
