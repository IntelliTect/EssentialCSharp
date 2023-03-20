namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter16.Listing16_07;

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
        ListByFileSize1(Directory.GetCurrentDirectory(), "*");
    }
    #endregion EXCLUDE
    public static void ListByFileSize1(
        string rootDirectory, string searchPattern)
    {
        IEnumerable<string> fileNames =
            from fileName in Directory.EnumerateFiles(
                rootDirectory, searchPattern)
                #region HIGHLIGHT
            orderby (new FileInfo(fileName)).Length descending,
                fileName
            #endregion HIGHLIGHT
            select fileName;

        foreach(string fileName in fileNames)
        {
            Console.WriteLine(fileName);
        }
    }
    //...
    #endregion INCLUDE
}
