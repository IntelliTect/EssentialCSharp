namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter16.Listing16_08;

#region INCLUDE
using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
#region EXCLUDE
public class Program
{
    public static void Main()
    {
        ListByFileSize2(Directory.GetCurrentDirectory(), "*");
    }
    #endregion EXCLUDE
    public static void ListByFileSize2(
        string rootDirectory, string searchPattern)
    {
        IEnumerable<FileInfo> files =
            from fileName in Directory.EnumerateFiles(
                rootDirectory, searchPattern)
                #region HIGHLIGHT
            orderby new FileInfo(fileName).Length, fileName
            select new FileInfo(fileName);
        #endregion HIGHLIGHT

        foreach (FileInfo file in files)
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
    //...
    #endregion INCLUDE
}
