namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter16.Listing16_03;

#region INCLUDE
using System;
using System.IO;
using System.Linq;
#region EXCLUDE
public class Program
{
    public static void Main()
    {
        List2(Directory.GetCurrentDirectory(), "*");
    }
    #endregion EXCLUDE
    public static void List2
        (string rootDirectory, string searchPattern)
    {
        #region HIGHLIGHT
        var fileNames = Directory.EnumerateFiles(
            rootDirectory, searchPattern);
        var fileResults =
            from fileName in fileNames
            select
            (
                Name: fileName,
                LastWriteTime: File.GetLastWriteTime(fileName)
            );
        #endregion HIGHLIGHT

        foreach (var fileResult in fileResults)
        {
            Console.WriteLine(
            #region HIGHLIGHT
                $@"{ fileResult.Name } ({ 
                    fileResult.LastWriteTime })");
            #endregion HIGHLIGHT
        }
    }
    //...
    #endregion INCLUDE
}