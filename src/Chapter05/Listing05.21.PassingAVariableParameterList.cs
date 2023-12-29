namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter05.Listing05_21;

#region INCLUDE
using System;
using System.IO;

public class Program
{
    public static void Main()
    {
        string fullName;

        // ...

        #region HIGHLIGHT
        // ��Combine()����4������
        fullName = Combine(
            Directory.GetCurrentDirectory(),
            "bin", "config", "index.html");
        #endregion HIGHLIGHT
        Console.WriteLine(fullName);

        // ...

        #region HIGHLIGHT
        // ֻ��Combine()����3������
        fullName = Combine(
            Environment.SystemDirectory,
            "Temp", "index.html");
        #endregion HIGHLIGHT
        Console.WriteLine(fullName);

        // ...

        #region HIGHLIGHT
        // ��Combine()����һ������
        fullName = Combine(
            new string[] {
                $"{Environment.GetFolderPath(Environment.SpecialFolder.UserProfile)}", "Documents",
                "Web", "index.html" });
        #endregion HIGHLIGHT
        Console.WriteLine(fullName);
        // ...
    }

    #region HIGHLIGHT
    static string Combine(params string[] paths)
    #endregion HIGHLIGHT
    {
        string result = string.Empty;
        foreach(string path in paths)
        {
            result = Path.Combine(result, path);
        }
        return result;
    }
}
#endregion INCLUDE
