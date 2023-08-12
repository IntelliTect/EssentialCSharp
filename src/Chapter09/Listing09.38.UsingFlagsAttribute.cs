namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter09.Listing09_38;

#region INCLUDE
//FileAttributes are defined in System.IO

using System;
using System.IO;

public class Program
{
    public static void Main()
    {
        string fileName = @"enumtest.txt";
        #region EXCLUDE
        // Cleanup in case the file is left in read-only state
        // and can't get created.
        if (File.Exists(fileName))
        {
            FileAttributes attrs = File.GetAttributes(fileName);
            if (attrs.HasFlag(FileAttributes.ReadOnly))
                File.SetAttributes(fileName, attrs & ~FileAttributes.ReadOnly);
        }
        #endregion EXCLUDE
        FileInfo file = new(fileName);
        file.Open(FileMode.OpenOrCreate).Dispose();

        FileAttributes startingAttributes =
            file.Attributes;

        file.Attributes = FileAttributes.Hidden |
            FileAttributes.ReadOnly;

        Console.WriteLine("\"{0}\" outputs as \"{1}\"",
            file.Attributes.ToString().Replace(",", " |"),
            file.Attributes);

        FileAttributes attributes =
            (FileAttributes)Enum.Parse(typeof(FileAttributes),
            file.Attributes.ToString());

        Console.WriteLine(attributes);

        File.SetAttributes(fileName,
            startingAttributes);
        file.Delete();
    }
}
#endregion INCLUDE
