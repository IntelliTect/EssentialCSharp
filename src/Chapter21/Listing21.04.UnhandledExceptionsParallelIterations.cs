namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter21.Listing21_04;

#region INCLUDE
using System;
using System.Collections.Generic;
using System.IO;
#region HIGHLIGHT
using System.Threading.Tasks;
#endregion HIGHLIGHT

public static class Program
{
    #region EXCLUDE
    public static void Main()
    {
        EncryptFiles(Directory.GetCurrentDirectory(), "*.*");
    }
    #endregion EXCLUDE
    static void EncryptFiles(
        string directoryPath, string searchPattern)
    {
        IEnumerable<string> files = Directory.EnumerateFiles(
            directoryPath, searchPattern,
            SearchOption.AllDirectories);
        try
        {
            Parallel.ForEach(files, fileName =>
            {
                Encrypt(fileName);
            });
        }
        #region HIGHLIGHT
        catch (AggregateException exception)
        #endregion HIGHLIGHT
        {
            Console.WriteLine(
                "ERROR: {0}:",
                exception.GetType().Name);
            foreach (Exception item in
            #region HIGHLIGHT
                exception.InnerExceptions)
            #endregion HIGHLIGHT
            {
                Console.WriteLine("  {0} - {1}",
                    item.GetType().Name, item.Message);
            }
        }
    }
    #region EXCLUDE
    private static void Encrypt(string fileName)
    {
        // ...

        throw new UnauthorizedAccessException();
    }
    #endregion EXCLUDE
}
#endregion INCLUDE
