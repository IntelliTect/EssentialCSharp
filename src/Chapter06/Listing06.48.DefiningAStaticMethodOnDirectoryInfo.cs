namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter06.Listing06_48;

using System;
using System.IO;


#region INCLUDE
public static class DirectoryInfoExtension
{
    #region HIGHLIGHT
    public static void CopyTo(
        DirectoryInfo sourceDirectory, string target,
        SearchOption option, string searchPattern)
    #endregion HIGHLIGHT
    {
        if (target[^1] !=
            Path.DirectorySeparatorChar)
        {
            target += Path.DirectorySeparatorChar;
        }
        Directory.CreateDirectory(target);

        for (int i = 0; i < searchPattern.Length; i++)
        {
            foreach (string file in
                Directory.EnumerateFiles(
                    sourceDirectory.FullName, searchPattern))
            {
                File.Copy(file,
                    target + Path.GetFileName(file), true);
            }
        }

        // Copy subdirectories (recursively)
        if (option == SearchOption.AllDirectories)
        {
            foreach (string element in
                Directory.EnumerateDirectories(
                    sourceDirectory.FullName))
            {
                Copy(element,
                    target + Path.GetFileName(element),
                    searchPattern);
            }
        }
    }
    #region EXCLUDE
    private static void Copy(string element, string fileName, string searchPattern)
    {
        Console.WriteLine(
            $"Copying(element: {element}, fileName: {fileName}, searchPattern: {searchPattern})");
    }
    #endregion EXCLUDE
}

public class Program
{
    public static void Main(params string[] args)
    {
        DirectoryInfo source = new(args[0]);
        string target = args[1];

        #region HIGHLIGHT
        DirectoryInfoExtension.CopyTo(
            source, target,
            SearchOption.AllDirectories, "*");
        #endregion HIGHLIGHT
    }
}
#endregion INCLUDE
