namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter15.Listing15_13;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public class Program
{
    public static void Main()
    {
        string rootDirectory = Directory.GetCurrentDirectory();
        string searchPattern = "*";
        #region INCLUDE
        //...
        IEnumerable<string> fileList = Directory.EnumerateFiles(
        rootDirectory, searchPattern);
        #region HIGHLIGHT
        IEnumerable<(string FileName, long Size)> items = fileList.Select(
            file =>
            {
                FileInfo fileInfo = new(file);
                return (
                    FileName: fileInfo.Name,
                    Size: fileInfo.Length
                );
            });
        #endregion HIGHLIGHT
        //...
        #endregion INCLUDE

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
