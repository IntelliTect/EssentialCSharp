namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter15.Listing15_27;

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
        var items = fileList.Select(
            file =>
            {
                FileInfo fileInfo = new(file);
                return new
                {
                    FileName = fileInfo.Name,
                    Size = fileInfo.Length
                };
            });
        #endregion HIGHLIGHT
        //...
        #endregion INCLUDE

        Print(items);
    }

    private static void Print<T>(IEnumerable<T> items)
    {
        foreach(T item in items)
        {
            Console.WriteLine(item);
        }
    }
}
