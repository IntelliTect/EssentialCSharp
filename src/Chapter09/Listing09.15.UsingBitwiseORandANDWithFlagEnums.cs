namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter09.Listing09_15
{
    #region INCLUDE
    using System;
    using System.IO;

    public class Program
    {
        public static void Main()
        {
            // ...

            string fileName = @"enumtest.txt";

            #region EXCLUDE
            System.IO.FileInfo enumFile =
                new System.IO.FileInfo(fileName);
            if (!enumFile.Exists)
            {
                enumFile.Create().Dispose();
            }

            try
            {
            #endregion EXCLUDE
                System.IO.FileInfo file =
                    new System.IO.FileInfo(fileName);

                file.Attributes = FileAttributes.Hidden |
                    FileAttributes.ReadOnly;

                Console.WriteLine($"{file.Attributes} = {(int)file.Attributes}");

                // Only the ReadOnly attribute works on Linux  (The Hidden attribute does not work on Linux)
                if (!System.Runtime.InteropServices.RuntimeInformation.IsOSPlatform(System.Runtime.InteropServices.OSPlatform.Linux))
                {
                    // Added in C# 4.0/Microsoft .NET Framework  4.0
                    if (!file.Attributes.HasFlag(FileAttributes.Hidden))
                    {
                        throw new Exception("File is not hidden.");
                    }
                }

                // Use bit operators prior to C# 4.0/.NET 4.0
                if ((file.Attributes & FileAttributes.ReadOnly) !=
                FileAttributes.ReadOnly)
                {
                    throw new Exception("File is not read-only.");
                }
            #region EXCLUDE
            }
            finally
            {
                if (enumFile.Exists)
                {
                    enumFile.Attributes = FileAttributes.Normal;
                    enumFile.Delete();
                }
            }
            #endregion EXCLUDE
        }
    }
    #endregion INCLUDE
}
