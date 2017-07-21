﻿namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter08.Listing08_16
{
    using System;
    using System.IO;

    public class Program
    {
        public static void Main()
        {
            // ...
            string fileName = @"enumtest.txt";
            System.IO.FileInfo enumFile =
                new System.IO.FileInfo(fileName);
            if (!enumFile.Exists)
            {
                enumFile.Create().Dispose();
            }

            try
            {
                System.IO.FileInfo file =
                    new System.IO.FileInfo(fileName);

                file.Attributes = FileAttributes.Hidden |
                    FileAttributes.ReadOnly;

                Console.WriteLine("{0} | {1} = {2}",
                    FileAttributes.Hidden, FileAttributes.ReadOnly,
                    (int)file.Attributes);

                // Added in C# 4.0/.NET 4.0
                if (!file.Attributes.HasFlag(FileAttributes.Hidden))
                {
                    throw new Exception("File is not hidden.");
                }

                // Use bit operators prior to C# 4.0/.NET 4.0
                if ((file.Attributes & FileAttributes.ReadOnly) !=
                FileAttributes.ReadOnly)
                {
                    throw new Exception("File is not read-only.");
                }
            }
            finally
            {
                if (enumFile.Exists)
                {
                    enumFile.Attributes = FileAttributes.Normal;
                    enumFile.Delete();
                }
            }
            // ...
        }
    }
}
