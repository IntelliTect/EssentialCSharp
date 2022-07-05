namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter15.Listing15_27
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    #region INCLUDE
    #region EXCLUDE
    public class Program
    {
        public static void Main()
        {
            string rootDirectory = Directory.GetCurrentDirectory();
            string searchPattern = "*";
            #endregion EXCLUDE
            IEnumerable<string> fileList = Directory.EnumerateFiles(
                rootDirectory, searchPattern);
            #region HIGHLIGHT
            var items = fileList.Select(
                file =>
                {
                    FileInfo fileInfo = new FileInfo(file);
                    return new
                    {
                        FileName = fileInfo.Name,
                        Size = fileInfo.Length
                    };
                });
            #endregion HIGHLIGHT
            #region EXCLUDE

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
    #endregion EXCLUDE
    #endregion INCLUDE
}
