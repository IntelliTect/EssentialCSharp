namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter16.Listing16_02;

#region INCLUDE
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
#region EXCLUDE
public class Program
{
    public static void Main()
    {
        List1(Directory.GetCurrentDirectory(), "*");
    }
    #endregion EXCLUDE
    public static void List1
        (string rootDirectory, string searchPattern)
    {
        #region HIGHLIGHT
        IEnumerable<string> fileNames = Directory.GetFiles(
            rootDirectory, searchPattern);

        IEnumerable<FileInfo> fileInfos =
            from fileName in fileNames
            select new FileInfo(fileName);
        #endregion HIGHLIGHT

        foreach (FileInfo fileInfo in fileInfos)
        {
            Console.WriteLine(
                $@".{ fileInfo.Name } ({
                    fileInfo.LastWriteTime })");
        }
    }
    //...
    #endregion INCLUDE
}