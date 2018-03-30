namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter16.Listing16_09
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.IO;

    public class Program
    {
        public static void Main()
        {
            ListByFileSize3(Directory.GetCurrentDirectory(), "*");
        }

        static void ListByFileSize3(
            string rootDirectory, string searchPattern)
        {
            IEnumerable<FileInfo> files =
                from fileName in Directory.GetFiles(
                    rootDirectory, searchPattern)
                let file = new FileInfo(fileName)
                orderby file.Length, fileName
                select file;


            foreach(FileInfo file in files)
            {
                //  As simplification, current directory is
                //  assumed to be a subdirectory of
                //  rootDirectory
                string relativePath = file.FullName.Substring(
                    Directory.GetCurrentDirectory().Length);
                Console.WriteLine( 
                    $".{ relativePath }({ file.Length })" );
            }
        }
    }
}
