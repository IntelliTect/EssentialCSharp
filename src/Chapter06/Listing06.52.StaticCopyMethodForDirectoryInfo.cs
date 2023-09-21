namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter06.Listing06_52;

using System;
using System.IO;

#region INCLUDE
public static class DirectoryInfoExtension
{
    public static void CopyTo(
    #region HIGHLIGHT
        this DirectoryInfo sourceDirectory, string target,
    #endregion HIGHLIGHT
        SearchOption option, string searchPattern)
    {
        #region EXCLUDE
        if (target[target.Length - 1] != Path.DirectorySeparatorChar)
        {
            target += Path.DirectorySeparatorChar;
        }
        if(!Directory.Exists(target))
        {
            Directory.CreateDirectory(target);
        }

        for(int i = 0; i < searchPattern.Length; i++)
        {
            foreach(string file in
                Directory.GetFiles(
                    sourceDirectory.FullName, searchPattern))
            {
                File.Copy(file,
                    target + Path.GetFileName(file), true);
            }
        }

        //Copy SubDirectories (recursively)
        if(option == SearchOption.AllDirectories)
        {
            foreach(string element in
                Directory.GetDirectories(
                    sourceDirectory.FullName))
            {
                Copy(element,
                    target + Path.GetFileName(element),
                    searchPattern);
            }
        }
    }

    private static void Copy(string element, string fileName, string searchPattern)
    {
        Console.WriteLine("Copying " + fileName);
        #endregion EXCLUDE
    }
}

#region EXCLUDE
public class Program
{
    public static void Main()
    {
        #endregion EXCLUDE
        DirectoryInfo directory = new(".\\Source");
        #region HIGHLIGHT
        directory.CopyTo(".\\Target",
            SearchOption.TopDirectoryOnly, "*");
        #endregion HIGHLIGHT
        #region EXCLUDE
        //Extension method. Is Defined above but appears to be a member of the DirectoryInfo object, directory, defined aboves
        #endregion EXCLUDE
    }
}
#endregion INCLUDE
